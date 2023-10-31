

let SelectedItems = []
let AddedPrices = []





let addToPoke = function (id) {
    let SelectedBase = []
    let SelectedProteine = []
    let SelectedContorni = []
    let SelectedToppings = []
    let SelectedSalse = []
    let FotoIngrediente = document.getElementById(id)
    let TipoIngrediente = FotoIngrediente.parentElement.getAttribute("type")
    let Price = FotoIngrediente.parentElement.getAttribute("price")
    
    switch (TipoIngrediente) {
        case "Base":
            if (SelectedItems.includes(id) == true) {
                alert = "Ingrediente giá inserito"
            } else {
                SelectedItems.push(id)
                SelectedBase.push(id)
                AddedPrices.push(Price)
                console.log("Ingredienti scelti:", SelectedItems)
                console.log("Prezzi aggiuntivi:", AddedPrices)
            }
            break;
        case "Proteina":
            if (SelectedItems.includes(id) == true || SelectedProteine.length >= 2) {
                alert = "Ingrediente giá inserito"
            } else {
                SelectedItems.push(id)
                SelectedProteine.push(id)
                AddedPrices.push(Price)
                console.log("Ingredienti scelti:", SelectedItems)
                console.log("Prezzi aggiuntivi:", AddedPrices)
            }
            break;
        case "Contorno":
            if (SelectedItems.includes(id) == true || SelectedContorni.lenght >= 4) {
                alert = "Ingrediente giá inserito"
            } else {
                SelectedItems.push(id)
                SelectedContorni.push(id)
                AddedPrices.push(Price)
                console.log("Ingredienti scelti:", SelectedItems)
                console.log("Prezzi aggiuntivi:", AddedPrices)
            }
            break;
        case "Topping":
            if (SelectedItems.includes(id) == true || SelectedToppings.lenght >= 2) {
                alert = "Ingrediente giá inserito"
            } else {
                SelectedItems.push(id)
                SelectedToppings.push(id)
                AddedPrices.push(Price)
                console.log("Ingredienti scelti:", SelectedItems)
                console.log("Prezzi aggiuntivi:", AddedPrices)
            }
            break;
        case "Salsa":
            if (SelectedItems.includes(id) == true || SelectedSalse.length >= 2) {
                alert = "Ingrediente giá inserito"
            } else {
                SelectedItems.push(id)
                SelectedToppings.push(id)
                AddedPrices.push(Price)
                console.log("Ingredienti scelti:", SelectedItems)
                console.log("Prezzi aggiuntivi:", AddedPrices)
            }
            break;
    }
    sessionStorage.setItem("Ingredienti", SelectedItems)
    sessionStorage.setItem("PrezziAggiuntivi", AddedPrices)
}





    

