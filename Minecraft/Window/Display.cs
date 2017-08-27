using System;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using OpenTK.Input;

namespace Minecraft.Window {
    public class Display : GameWindow {
        private const int SCREEN_WIDTH = 1280;
        private const int SCREEN_HEIGHT = 720;

        private const string TITLE = "Minecraft";

        public event EventHandler<FrameEventArgs> OnFrameRender;

        public Display() : base(SCREEN_WIDTH, SCREEN_HEIGHT, GraphicsMode.Default, "PongTK") {

        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            //OnFrameRender?.Invoke(this, new FrameEventArgs());
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);

            GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);
        }

        protected override void OnRenderFrame(FrameEventArgs e) {
            base.OnRenderFrame(e);

            GL.EnableClientState(ArrayCap.VertexArray);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.ClearColor(Color.Black);

            OnFrameRender?.Invoke(this, e);

            SwapBuffers();
        }

        // Keyboard event callbacks.
        protected override void OnKeyDown(KeyboardKeyEventArgs e) {
            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyboardKeyEventArgs e) {
            base.OnKeyUp(e);
        }

        // Mouse event callbacks
        protected override void OnMouseDown(MouseButtonEventArgs e) {
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseButtonEventArgs e) {
            base.OnMouseUp(e);
        }

        protected override void OnMouseWheel(MouseWheelEventArgs e) {
            base.OnMouseWheel(e);
        }

        protected override void OnMouseMove(MouseMoveEventArgs e) {
            base.OnMouseMove(e);
        }
    }
}