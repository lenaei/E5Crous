namespace crous.models
{
    public class Appartement
    {
        public int IdAppartement { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public decimal Superficie { get; set; }

        public override string ToString()
        {
            return $"{Libelle} - {Adresse}, {Ville} ({Superficie} m²)";
        }
    }
}
