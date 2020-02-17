using System;
using System.Collections.Generic;
using System.Text;

namespace TVCommandPattern
{
    public class TV
    {
        private int volume, channel;

        private bool tvPower;

        public bool TVPower { get { return this.tvPower; } protected set { tvPower = value; } }

        public int Volume { get { return this.volume; } protected set { volume = value; } }
        public int Channel { get { return this.channel; } protected set { channel = value; } }

        internal void VolumeUp()
        {
            this.Volume++;
        }

        internal void VolumeDown()
        {
            this.Volume--;
        }

        internal void ChannelUp()
        {
            this.Channel++;
        }

        internal void ChannelDown()
        {
            this.Channel--;
        }

        internal void TvON()
        {
            this.TVPower = true;
        }

        internal void TvOFF()
        {
            this.TVPower = false;
        }
    }
}
