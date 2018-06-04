namespace lesson5
{
    public class Processor
    {
        public string _model;
        public string _vendor;
        public float _frequency;

    }

    public class VideoCard
    {
       public string _model;
        public string _vendor;
        public float _frequency;
        public byte _memory;

    }

    public class Computer
    {
        Processor _processor;
        public byte _memory;
        VideoCard _videocard;

        public int _hDD;
       
    }

}