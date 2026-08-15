using System.Text.Json;
using System.Drawing;

namespace MyFirstWindowsApp
{
    public partial class Form1 : Form
    {
        private List<LauncherApp> launcherApps = new List<LauncherApp>();
        public Form1()
        {
            InitializeComponent();

            addButton.TextAlign = ContentAlignment.MiddleCenter;

            LoadLauncherApps();

            flowLayoutPanel1.Resize += (s, e) => CenterButtons();
            CenterButtons();

            PositionAddButton();
            Resize += (s, e) => PositionAddButton();
        }

        private void CenterButtons()
        {
            int totalWidth = 0;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                totalWidth += control.Width + control.Margin.Left + control.Margin.Right;
            }

            int leftMargin = Math.Max(
                0,
                (flowLayoutPanel1.ClientSize.Width - totalWidth) / 2
            );

            flowLayoutPanel1.Padding = new Padding(leftMargin, 20, 0, 0);
        }
        private void launcherButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "steam://open/main",
                UseShellExecute = true
            });
        }
        private void PositionAddButton()
        {
            addButton.Left = (ClientSize.Width - addButton.Width) / 2;
            addButton.Top = ClientSize.Height - addButton.Height - 20;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (AddApplicationForm form = new AddApplicationForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CreateLauncherButton(form.ApplicationName, form.ExePath);
                }
            }
        }
        private void CreateLauncherButton(string appName, string exePath, bool save = true)
        {
            if (save)
            {
                launcherApps.Add(new LauncherApp
                {
                    Name = appName,
                    ExePath = exePath
                });

                SaveLauncherApps();
            }
            Button button = new Button();

            try
            {
                Icon? icon = Icon.ExtractAssociatedIcon(exePath);

                if (icon != null)
                {
                    button.Image = icon.ToBitmap();
                    button.ImageAlign = ContentAlignment.TopCenter;
                    button.TextImageRelation = TextImageRelation.ImageAboveText;
                }
            }
            catch
            {
                // If the executable has no usable icon, keep the normal button.
            }

            button.Text = appName;
            button.Size = new Size(160, 130);
            button.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            button.Margin = new Padding(15);

            button.Click += (sender, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = exePath,
                    UseShellExecute = true
                });
            };

            button.MouseUp += (sender, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    DialogResult result = MessageBox.Show(
                        $"Remove {appName} from the launcher?",
                        "Remove Application",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        LauncherApp? appToRemove = launcherApps.FirstOrDefault(
                            app => app.Name == appName && app.ExePath == exePath
                        );

                        if (appToRemove != null)
                        {
                            launcherApps.Remove(appToRemove);
                            SaveLauncherApps();
                        }

                        flowLayoutPanel1.Controls.Remove(button);
                        button.Dispose();

                        CenterButtons();
                    }
                }
            };

            flowLayoutPanel1.Controls.Add(button);
            CenterButtons();
        }
        private void SaveLauncherApps()
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "launcherApps.json"
            );

            string json = JsonSerializer.Serialize(
                launcherApps,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

            File.WriteAllText(filePath, json);
        }
        private void LoadLauncherApps()
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "launcherApps.json"
            );

            if (!File.Exists(filePath))
                return;

            string json = File.ReadAllText(filePath);

            launcherApps = JsonSerializer.Deserialize<List<LauncherApp>>(json)
                           ?? new List<LauncherApp>();

            foreach (LauncherApp app in launcherApps)
            {
                CreateLauncherButton(app.Name, app.ExePath, false);
            }
        }
    }
}
