using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SFML.Graphics;
using SFML.Window;

namespace Minecraft {
    public class Display {
        private const int WIDTH = 1280;
        private const int HEIGHT = 720;

        private const string TITLE = "Minecraft";

        private RenderWindow window;

        public Display() {

        }

        /// <summary>
        /// Function that initializes the SFML window that acts as a canvas to render the
        /// game on.
        /// </summary>
        public void Init() {
            var settings = new ContextSettings();
            settings.DepthBits = 24;
            settings.MajorVersion = 3;
            settings.MinorVersion = 3;

            var mode = new VideoMode(WIDTH, HEIGHT);
            window = new RenderWindow(mode, "Minecraft", Styles.Close, settings);

            window.Closed += WindowClosed;
        }

        public void ProcessEvents() {
            window.DispatchEvents();
        }

        public void Update() {

        }

        public void Clear() {

        }

        public bool IsOpen() {
            return window.IsOpen();
        }

        public void Close() {

        }

        private void WindowClosed(object sender, EventArgs e) {
            window.Close();
        }
    }
}
