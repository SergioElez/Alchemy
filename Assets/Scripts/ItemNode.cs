using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
public class ItemNode
{
    public Item item;
    public ItemNode firstChild;
    public ItemNode nextSibling;

    public ItemNode(Item item, ItemNode firstChild, ItemNode nextSibling)
    {
        this.item = item;
        this.firstChild = firstChild;
        this.nextSibling = nextSibling;
    }

    private List<Item> traverse(List<Item> recipes)
    {
        recipes.Add(this.item);

        if (this.nextSibling != null)
        {
            recipes = this.nextSibling.traverse(recipes);
        }

        return recipes;
    }

    public List<Item> findRecipes(string item)
    {
        List<Item> recipes = new List<Item>();

        if(this.item.name.Equals(item))
        {
            if (this.firstChild != null)
            {
                recipes = this.firstChild.traverse(recipes);
            }
        }
        else
        {
            if(this.nextSibling != null)
            {
                recipes = this.nextSibling.findRecipes(item);
            }
        }

        return recipes;
    }
}


public class ItemTree {

    ItemNode root;
    static ItemTree instance = null;

    public static ItemTree getInstance()
    {
        if(instance == null) 
        {
            instance = new ItemTree();
        }
        return instance;
    }
    public List<Item> findRecipes(string item)
    {
        return root.firstChild.findRecipes(item);
    }

    private ItemTree()
    {
        ItemNode newRecipe = new ItemNode(new Item("muñeco de pruebas", "Un munieco de pruebas para pegarle fuerte. Puede que te joda la run pacifista."), null, null);
        ItemNode nodoEspada = new ItemNode(new Item("espada madera", "Una espada de madera para ninios."), null, newRecipe);
        ItemNode escudoMadera = new ItemNode(new Item("escudo madera", "Escudo deku"), null, nodoEspada);
        ItemNode armadura = new ItemNode(new Item("armadura", "De hierro de la mina."), null, null);
        ItemNode metal = new ItemNode(new Item("metal", "Un lingotito"), armadura, null);
        ItemNode piedra = new ItemNode(new Item("piedra", "Cobblestone"), null, metal);
        ItemNode madera = new ItemNode(new Item("madera", "Recien obtenida a punietazos."), escudoMadera, piedra);
        this.root = new ItemNode(new Item("root", "La raiz de todo mal."), madera, null);
    }
}