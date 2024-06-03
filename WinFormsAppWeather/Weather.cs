using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsAppWeather
{
    public class Weather
    {
        public static Random rnd = new Random();

        public int Temperature = 0;
        public virtual String GetInfo()
        {
            var str = String.Format("\nТемпература: {0}", this.Temperature);
            return str;
        }
    }
    public enum TF { присутствует, отсутствует };
    public class Sun : Weather
    {        
        public int HeightHorizon = 0; // высота над горизонтом
        public TF Breeze = TF.отсутствует; // наличие ветерка

        public override String GetInfo()
        {
            var str = "Солнечная погода";
            str += base.GetInfo();
            str += String.Format("\nСолнышко поднялось на: {0}", this.HeightHorizon);
            str += String.Format("\nВетерок: {0}", this.Breeze);
            return str;
        }
        public static Sun Generate()
        {          
            return new Sun
            {
                Temperature = -40 + rnd.Next() % 81, // температура от -40 до 40
                HeightHorizon = 20 + rnd.Next() % 50, // высота солнца от 20 до 50
                Breeze = (TF)rnd.Next(2) // наличие ветерка true или false
            };
        }
    }

    public class Rain : Weather
    {
        public int Precipitation = 0; // осадки
        public TF Rainbow = TF.отсутствует; // наличие радуги
        public TF Thunderstorm = TF.отсутствует; // наличие грозы

        public override String GetInfo()
        {
            var str = "За окном дождик";
            str += base.GetInfo();
            str += String.Format("\nОсадки: {0}", this.Precipitation);
            str += String.Format("\nРадуга: {0}", this.Rainbow);
            str += String.Format("\nГроза: {0}", this.Thunderstorm);
            return str;
        }
        public static Rain Generate()
        {
            return new Rain
            {
                Temperature = -40 + rnd.Next() % 81, // температура от -40 до 40
                Precipitation = 1 + rnd.Next() % 50, // осадки от 1 до 50
                Rainbow = (TF)rnd.Next(2), // наличие радуги true или false
                Thunderstorm = (TF)rnd.Next(2) // наличие грозы true или false
            };
        }
    }

    public enum Type { мелкий, хлопьями, мокрый};
    public class Snow : Weather
    {
        public Type SnowType = Type.мелкий; // тип снега
        public int HeightSnowdrift = 0; // высота сугроба

        public override String GetInfo()
        {            
            var str = "Идет снег";
            str += base.GetInfo();
            str += String.Format("\nТип снега: {0}", this.SnowType);
            str += String.Format("\nВысота сугроба: {0}", this.HeightSnowdrift);
            return str;
        }
        public static Snow Generate()
        {
            return new Snow
            {
                Temperature = -40 + rnd.Next() % 41, // температура от -40 до 40
                SnowType = (Type)rnd.Next(2), //тип снега
                HeightSnowdrift = rnd.Next() % 10 // высота сугроба от 0 до 10
            };
        }
    }    
}