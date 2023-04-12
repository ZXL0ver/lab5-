using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buider
{
    public abstract class lantern
    {
        public abstract lantern Copy();
    }

    public class lantarn : lantern
    {
        public string pillar, wiring, lamp;
        public string Data() => pillar + "\n" + wiring + "\n" + lamp + "\n";
        public void GetPillar(string dat) => pillar = dat;
        public void GetWiring(string dat) => wiring = dat;
        public void GetLamp(string dat) => lamp = dat;


        public override lantern Copy()
        {
            lantarn clone = (lantarn)this.MemberwiseClone();
            clone.pillar = String.Copy(pillar);
            clone.wiring = String.Copy(wiring);
            clone.lamp = String.Copy(lamp);
            return clone;
        }
    }

    public interface Builder
    {
        void BuildPillar();

        void BuildWiring();

        void BuildLamp();
        lantarn GetLamp();
    }
    public class lanternBuilder : Builder
    {
        private lantarn lat;

        public lanternBuilder()
        {
            lat = new lantarn();
        }

        public void BuildPillar()
        {
            lat.GetPillar("pillar");
        }

        public void BuildWiring()
        {
            lat.GetWiring("Wiring");
        }

        public void BuildLamp()
        {
            lat.GetLamp("lamp");
        }
        public lantarn GetLamp() => lat;
    }
    public class GoodlanternBuilder : Builder
    {
        private lantarn lat;

        public GoodlanternBuilder()
        {
            lat = new lantarn();
        }
        public void BuildPillar()
        {
            lat.GetPillar("good pillar");
        }
        public void BuildWiring()
        {
            lat.GetWiring("good Wiring");
        }

        public void BuildLamp()
        {
            lat.GetLamp("awaseme lamp");
        }
        public lantarn GetLamp() => lat;

    }
    public class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;

        }
        public void Choselantern(Builder builder)
        {
            this.builder = builder;
        }

        public lantarn Buildpiz()
        {
            builder.BuildPillar();
            builder.BuildWiring();
            builder.BuildLamp();
            return builder.GetLamp();
        }

    }
}
