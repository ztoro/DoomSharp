using System;
using FluidSynthWrapper;

namespace DoomSharp
{
    public sealed class MusicNoteOffEvent : MusicEvent
    {
        private int note;

        public MusicNoteOffEvent(int note,int channel,int delay) : base(channel,delay)
        {
            if (note < 0 || note >= 128)
                throw new ArgumentOutOfRangeException("note");
            this.note = note;
        }

        public int Note
        {
            get { return note; }
        }

        public override void Play(Synthesizer synth)
        {
            synth.NoteOff(MIDIChannel,(short)note);
        }
    }
}
