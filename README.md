# Proyecto alchemy

## Descripción
El juego consiste en que eres el dueño de una tienda de
articulos. Cada cierto tiempo, aparecen clientes que compran
dependiendo del precio los productos que has expuesto.

Estos productos se tienen que craftear mediante combinar
objetos y / o elementos entre sí.

Los elementos básicos se compran a proveedores que ponen un
precio y cantidad base. Y cuanto más famoso seas mejores
productoso te venden.

Los precios varian segun el mercado y van subiendo y bajando
de "precio ideal".

### Resumen para vagos
Idea original de alchemy + moonlighter.

## Gameplay
### Bucle jugable
- Pides elementos a proveedores que dependiendo de tu fama
  te ofrecen unos precios y materiales diferentes.
- Con esos elementos crafteas items complejos como espadas,
  armaduras y pociones.
- Esos items complejos se venden a los aventureros, lo que
  te proporciona dinero y fama.
- Y el bucle se repite hasta que consigas X dinero o X fama.

### Encargos de expedición
En estos pedidos, el aventurero te dice a que zona va a ir y
el nivel de dificultad de la zona y que peligros hay en
ella. Entonces tu eres el que tiene que decidir que items le
das para sobrevivir a esa zona.

Dependiendo de si lo hace o no, ganaras o perderas fama y si
sobrevive te dara objetos de esa zona en concreto.

#### Contratación de aventureros
Puedes pagar a un aventurero para que haga una expedición a
la zona que tu eligas y con la dificultad que tu decides.

Los aventureros tienen un valor al igual que los encargos de expedición pero no
depende de tí sino que esta predefinido. Tienes que jugar con la dificultad
adecuada para su valor mientras la balanceas para obtener los items que quieres.

### Modas
Cada cierto tiempo un item se pone de moda. Este item pasa a
valer mucho mas dinero y mucha gente lo quiere. Una vez se
acaba la moda, el item se devalua por debajo de su precio
original y poca gente lo quiere.

### Tipos de clientes
Se generan clientes dependiendo de tu fama ( niños, aventureros, etc...)

Estos clientes tienen gustos diferentes y compran cosas
diferentes.

Los gustos estan basados en etiquetas como ( ligero, pesado, etc... )

Si estos gustos pegan con la persona el valor aumenta y por
lo tanto no solo te pagaran mas dinero si no que recibiras
mas objetos y fama.

### Pensando
#### Colores
Añadir colores a la ropa y armaduras👕.

## Programación
### Combinaciones
Un arbol no-binario en el que cada nodo contiene un
elemento. Para ver las combinaciones de ese nodo, recorres
los hijos que son los elementos con los que se puede
combinar, y los hijos de ese, son el resultado.

### Pocion de botella
Cuando se la das a un aventurero se combierte en una
botella, no ganas ni pierdes fama. Consigues menos
materiales y la botella(el aventurero).

## Enlaces
[Recetas](docs/recipes.md)
