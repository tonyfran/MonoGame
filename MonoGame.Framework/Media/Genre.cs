﻿#if WINDOWS_PHONE
extern alias MicrosoftXnaFramework;
using MsGenre = MicrosoftXnaFramework::Microsoft.Xna.Framework.Media.Genre;
#endif
using System;

namespace Microsoft.Xna.Framework.Media
{
    public sealed class Genre : IDisposable
    {
#if WINDOWS_PHONE
        private MsGenre genre;

        /// <summary>
        /// Gets the AlbumCollection for the Genre.
        /// </summary>
        public AlbumCollection Albums
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets a value indicating whether the object is disposed.
        /// </summary>
        public bool IsDisposed
        {
            get
            {
                return this.genre.IsDisposed;
            }
        }

        /// <summary>
        /// Gets the name of the Genre.
        /// </summary>
        public string Name
        {
            get
            {
                return this.genre.Name;
            }
        }

        /// <summary>
        /// Gets the SongCollection for the Genre.
        /// </summary>
        public SongCollection Songs
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static implicit operator Genre(MsGenre genre)
        {
            return new Genre(genre);
        }

        private Genre(MsGenre genre)
        {
            this.genre = genre;
        }

        /// <summary>
        /// Immediately releases the unmanaged resources used by this object.
        /// </summary>
        public void Dispose()
        {
            this.genre.Dispose();
        }

        /// <summary>
        /// Returns a String representation of the Genre.
        /// </summary>
        public override string ToString()
        {
            return this.genre.ToString();
        }

        /// <summary>
        /// Gets the hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            return this.genre.GetHashCode();
        }
#endif
    }
}
