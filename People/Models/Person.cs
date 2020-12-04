using SQLite;

namespace People.Models
{
    [Table("people")]
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        // name capture 
        [MaxLength(250), Unique]
        public string Name { get; set; }

        // Gender capture
        [MaxLength(250), Unique]
        public string Gender { get; set; }

        // TShirt_Size capture
        [MaxLength(250), Unique]
        public string TShirt_Size { get; set; }

        // TShirt_Color capture
        [MaxLength(250), Unique]
        public string TShirt_Color { get; set; }

        // Shipping_address capture
        [MaxLength(250), Unique]
        public string Shipping_address { get; set; }

        // post_address capture
        [MaxLength(250), Unique]
        public string Post_address { get; set; }
    }
}
