public class Pessoa
{
    public string Nome { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }
    public double IMC { get => Peso / (Altura * Altura); }
}