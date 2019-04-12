using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGame.src.Model
{
    /// <summary>
    /// The different AI levels.
    /// </summary>
    public enum AIOption
    {
        /// <summary>
        /// Easy, total random shooting.
        /// </summary>
        Easy,

        /// <summary>
        /// Medium, marks squares around hits.
        /// </summary>
        Medium,

        /// <summary>
        /// As medium, but removes the shots once it misses.
        /// </summary>
        Hard
    }
}
