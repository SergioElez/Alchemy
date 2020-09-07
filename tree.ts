class Item {
    name = '';
    desc = '';

    constructor(name, desc) {
        this.name = name;
        this.desc = desc;
    }
}
class TreeNode {
    element;
    firstChild;
    nextSibling;

    constructor(value, firstChild, nextSibling) {
        this.element = value;
        this.firstChild = firstChild;
        this.nextSibling = nextSibling;
    }

    traverse(recipes) {

        recipes.push(this.element);

        if (this.nextSibling)
            recipes = this.nextSibling.traverse(recipes);

        return recipes;
    }

    findRecipes(element) {
        let recipes = [];

        if (this.element.name === element) {
            if (this.firstChild)
                recipes = this.firstChild.traverse(recipes);
        }
        else {
            if (this.nextSibling) {
                recipes = this.nextSibling.findRecipes(element);
            }
        }

        return recipes;
    }
}

const newRecipe = new TreeNode(new Item('Muñeco de pruebas', 'Un munieco de pruebas para pegarle fuerte. Puede que te joda la run pacifista.'), null, null);
const nodoEspada = new TreeNode(new Item('espada madera', 'Una espada de madera para ninios.'), null, newRecipe);
const escudoMadera = new TreeNode(new Item('escudo madera', 'Escudo deku'), null, nodoEspada);
const armadura = new TreeNode(new Item('armadura', 'De hierro de la mina.'), null, null);
const metal = new TreeNode(new Item('metal', 'un lingotito'), armadura, null);
const piedra = new TreeNode(new Item('piedra', 'Cobblestone'), null, metal);
const madera = new TreeNode(new Item('madera', 'Recien obtenida a punietazos.'), escudoMadera, piedra);
const root = new TreeNode(new Item('root', 'la raiz de todo mal.'), madera, null);

const recipes = root.firstChild.findRecipes('madera');

recipes.forEach((item, index) => {
    console.log('Nombre: ' + item.name);
    console.log('Desc: ' + item.desc);
    console.log();
})
