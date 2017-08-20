using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft {
    class Model {
        protected OpenGL gl;

        protected uint vertexId;
        
        public Model(OpenGL openGl, float[] vertexPositions) {
            gl = openGl;
            gl.GenBuffers(1, new uint[] { vertexId });
            gl.BindBuffer(OpenGL.GL_ARRAY_BUFFER, vertexId);
            gl.BufferData(OpenGL.GL_ARRAY_BUFFER,
                          vertexPositions,
                          (uint) vertexPositions.Count() * sizeof(float));

            gl.VertexAttribPointer(0, 2, OpenGL.GL_FLOAT, false, 0, IntPtr.Zero);

            gl.EnableVertexAttribArray(0);
        }  

        ~Model() {
            gl.DeleteBuffers(1, new uint[] { vertexId });
        }

        public void Bind() {
            gl.BindBuffer(OpenGL.GL_ARRAY_BUFFER, vertexId);
        }

        public void UnBind() {
            gl.BindBuffer(OpenGL.GL_ARRAY_BUFFER, 0);
        }
        
    }
}
