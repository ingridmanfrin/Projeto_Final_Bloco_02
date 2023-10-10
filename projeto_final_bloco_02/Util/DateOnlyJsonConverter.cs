
namespace projeto_final_bloco_02.Util
{
    public class DateOnlyJsonConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public DateOnlyJsonConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
