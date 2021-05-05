public class Item 
{
    public string name;
    public int stock;
    public int price;

    /// <summary>
    /// Construtor da classe Item
    /// </summary>
    /// <param name="n">nome do item</param>
    /// <param name="s">stock do item</param>
    /// <param name="p">preço unitário do item</param>
    public Item(string n, int s, int p)
    {
        this.name = n;
        this.stock = s;
        this.price = p;
    }

    //revisitar video de conversão de dados
    public override string ToString()
    {
        //reservados 24 espaços para o nome dos items e 3 para o preço
        return $"{name, 24} - {price, 3}$ x{stock}";
    }
}