using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace Wpf_26
{
    //    public partial class App : Application
    //    {

    //        protected override void OnExit(ExitEventArgs e)
    //        {
    //            // Сохранение состояния приложения
    //            // ...
    //        }

    //    }
    //    public partial class App : Application
    //    {
    //        protected override void OnStartup(StartupEventArgs e)
    //        {
    //            base.OnStartup(e);

    //            // Восстановление состояния приложения
    //            // ...
    //        }
    //    }

    //    public partial class App : Application
    //    {
    //        private const string WindowSettingsFileName = "windowSettings.xml";

    //        protected override void OnExit(ExitEventArgs e)
    //        {
    //            base.OnExit(e);

    //            // Получение и сохранение расположения окна
    //            var mainWindow = MainWindow as MainWindow;
    //            var windowSettings = new WindowSettings();
    //            windowSettings.Left = mainWindow.Left;
    //            windowSettings.Top = mainWindow.Top;
    //            windowSettings.Width = mainWindow.Width;
    //            windowSettings.Height = mainWindow.Height;

    //            using (var stream = File.Create(WindowSettingsFileName))
    //            {
    //                var serializer = new XmlSerializer(typeof(WindowSettings));
    //                serializer.Serialize(stream, windowSettings);
    //            }
    //        }

    //        protected override void OnStartup(StartupEventArgs e)
    //        {
    //            base.OnStartup(e);

    //            // Восстановление расположения окна
    //            if (File.Exists(WindowSettingsFileName))
    //            {
    //                using (var stream = File.OpenRead(WindowSettingsFileName))
    //                {
    //                    var serializer = new XmlSerializer(typeof(WindowSettings));
    //                    var windowSettings = (WindowSettings)serializer.Deserialize(stream);

    //                    var mainWindow = new MainWindow();
    //                    mainWindow.Left = windowSettings.Left;
    //                    mainWindow.Top = windowSettings.Top;
    //                    mainWindow.Width = windowSettings.Width;
    //                    mainWindow.Height = windowSettings.Height;
    //                    mainWindow.Show();
    //                }
    //            }
    //            else
    //            {
    //                var mainWindow = new MainWindow();
    //                mainWindow.Show();
    //            }
    //        }
    //    }

    //    [Serializable]
    //    public class WindowSettings
    //    {
    //        public double Left { get; set; }
    //        public double Top { get; set; }
    //        public double Width { get; set; }
    //        public double Height { get; set; }
    //    }

    //}
}

