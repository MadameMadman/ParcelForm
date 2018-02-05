namespace ParcelForm.Models
{
    public class ParcelVariables
    {
        private int _volume;


        public void SetDimensions(string height, string width)
        {
            _volume = int.Parse(width) * int.Parse(height);
        }

        public int Volume()
        {
          return _volume;
        }

        public float CostToShip()
        {
          return _volume *.01f;
        }



    }
}
