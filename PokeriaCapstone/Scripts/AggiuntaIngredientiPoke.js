

let SelectedItems = []

let SelectedBase = []
let SelectedProteine = []
let SelectedContorni = []
let SelectedToppings = []
let SelectedSalse = []

let addBase = function (id) {
    console.log(id)
    if (SelectedItems.includes(id) == true || SelectedItems.length == 9) {
        alert("Ingrediente giá inserito")
    } else {
        if (SelectedBase.lenght >= 1) {
            alert("Ingrediente giá inserito")
        }
        else
        {
            document.getElementById(id).classList.toggle("IngredienteInserito")
            SelectedItems.push(id) 
            SelectedBase.push(id)
            console.log(SelectedBase, SelectedItems)
        }
    }
}

let addProteina = function (id) {
    console.log(id)
    if (SelectedItems.includes(id) == true || SelectedItems.length == 9) {
        alert("Ingrediente giá inserito")
    } else {
        if (SelectedProteine.lenght >= 2) {
            alert("Ingrediente giá inserito")
        }
        else {
            document.getElementById(id).classList.toggle("IngredienteInserito")
            SelectedItems.push(id)
            SelectedProteine.push(id)
            console.log(SelectedItems, SelectedProteine)
        }
    }
}


let addContorno = function (id) {
    console.log(id)
    if (SelectedItems.includes(id) == true || SelectedItems.length == 9) {
        alert("Ingrediente giá inserito")
    } else {
        if (SelectedContorni.lenght >= 4) {
            alert("Hai inserito il massimo numero di contorni")
        }
        else {
            document.getElementById(id).classList.toggle("IngredienteInserito")
            SelectedItems.push(id)
            SelectedContorni.push(id)
            console.log(SelectedItems, SelectedContorni)
        }
    }
}

let addTopping = function (id) {
    console.log(id)
    if (SelectedItems.includes(id) == true || SelectedItems.length == 9) {
        alert("Ingrediente giá inserito")
    } else {
        if (SelectedToppings.lenght >= 2) {
            alert("Hai inserito il massimo numero di topping")
        }
        else {
            document.getElementById(id).classList.toggle("IngredienteInserito")
            SelectedItems.push(id)
            SelectedToppings.push(id)
            console.log(SelectedItems, SelectedToppings)
        }
    }
}

let addSalsa = function (id) {
    console.log(id)
    if (SelectedItems.includes(id) == true || SelectedItems.length == 9) {
        alert("Ingrediente giá inserito")
    } else {
        if (SelectedSalse.lenght >= 1) {
            alert("Hai inserito il massimo numero di salse")
        }
        else {
            document.getElementById(id).classList.toggle("IngredienteInserito")
            SelectedItems.push(id)
            SelectedSalse.push(id)
            console.log(SelectedItems, SelectedSalse)
        }
    }
}


    

