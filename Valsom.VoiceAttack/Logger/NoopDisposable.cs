using System;

namespace Valsom.VoiceAttack.Logger
{
    /// <summary>
    /// NoopDisposable helper class
    /// </summary>
    public class NoopDisposable : IDisposable
    {
        /// <summary>
        /// Disposes
        /// </summary>
        public void Dispose()
        {
        }
    }
}