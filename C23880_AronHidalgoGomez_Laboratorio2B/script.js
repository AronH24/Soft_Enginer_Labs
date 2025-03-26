let elementosLista = document.getElementById("lista");
function agregar() {
	let numeroElementos = elementosLista.children.length;
	numeroElementos++;
	let nuevoElemento = document.createElement("li");
	nuevoElemento.innerText = "Elemento" + numeroElementos;
	elementosLista.appendChild(nuevoElemento);
}

function borrar() {
	elementosLista.removeChild(elementosLista.lastChild);
}

function cambiarFondo() {
	let windowColor = document.body.style.backgroundColor;
	if (windowColor === "" || windowColor === "white") {
		document.body.style.backgroundColor = "aquamarine";
	} else {
		document.body.style.backgroundColor = "white";
	}
}