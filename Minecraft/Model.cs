using System;
using System.Collections.Generic;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Minecraft {
    class Model {
        protected int vboId;

        protected int vao;

        protected List<int> buffers;

        protected int vboCount;

        public Model(Vector2[] vertexPositions) {
            buffers = new List<int>();

            vao = GL.GenVertexArray();

            GL.BindVertexArray(vao);

            AddVbo(2, vertexPositions);

            GL.BindVertexArray(0);

            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //buffers = new List<int>();
            //
            //vboId = GL.GenBuffer();
            //vaoId = GL.GenVertexArray();
            //
            //GL.BindBuffer(BufferTarget.ArrayBuffer, vboId);
            //
            //GL.BufferData<Vector2>(BufferTarget.ArrayBuffer,
            //              (IntPtr)(Vector2.SizeInBytes * vertexPositions.Length),
            //              vertexPositions,
            //              BufferUsageHint.StaticDraw);
            //
            //GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);
            //
            //GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
        }

        public void Bind() {
            GL.BindVertexArray(vao);
            //GL.BindBuffer(vbo);
        }

        public void UnBind() {
            GL.BindVertexArray(0);
        }

        public void AddVbo(int dim, Vector2[] data) {
            int vbo = GL.GenBuffer();

            GL.EnableVertexAttribArray(vboCount++);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BufferData<Vector2>(BufferTarget.ArrayBuffer,
                          (IntPtr)(Vector2.SizeInBytes * data.Length),
                          data,
                          BufferUsageHint.StaticDraw);

            GL.VertexPointer(dim, VertexPointerType.Float, Vector2.SizeInBytes, 0);

            buffers.Add(vbo);
        }
    }
}
