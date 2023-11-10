

let SelectedItems = []
let AddedPrices = []
let SelectedProteine = []
let SelectedContorni = []
let SelectedToppings = []
let SelectedSalse = []


let addToPoke = function (id) {
    let SelectedBase = []
    
    
    
    let FotoIngrediente = document.getElementById(id)
    let TipoIngrediente = FotoIngrediente.parentElement.getAttribute("type")
    let Price = FotoIngrediente.parentElement.getAttribute("price")
    
    switch (TipoIngrediente) {
        case "Base":
            if (SelectedItems.includes(id) == true) {
                alert ("Ingrediente giá inserito")
            } else {
                SelectedItems.push(id)
                SelectedBase.push(id)
                AddedPrices.push(Price)
                FotoIngrediente.classList.toggle("IngredienteInserito")
                document.getElementById("ProteinsSection").scrollIntoView({ behavior: 'smooth' });
                console.log("Ingredienti scelti:", SelectedItems)
                console.log("Prezzi aggiuntivi:", AddedPrices)

            }
            break;
        case "Proteina":
            if (SelectedItems.includes(id) == true || SelectedProteine.length >= 1) {
                alert("Ingrediente giá inserito")
            } else {
                SelectedItems.push(id)
                SelectedProteine.push(id)
                AddedPrices.push(Price)
                FotoIngrediente.classList.toggle("IngredienteInserito")
                document.getElementById("ContorniSection").scrollIntoView({ behavior: 'smooth' })
                console.log("Ingredienti scelti:", SelectedItems)
                console.log("Prezzi aggiuntivi:", AddedPrices)    
            }
            break;
        case "Contorno":
            if (SelectedItems.includes(id) == true || SelectedContorni.lenght >= 4) {
                alert("Ingrediente giá inserito")
            } else {
                SelectedItems.push(id)
                SelectedContorni.push(id)
                AddedPrices.push(Price)
                FotoIngrediente.classList.toggle("IngredienteInserito")
                if (SelectedContorni.length === 4) {
                    document.getElementById("ToppingSection").scrollIntoView({ behavior: 'smooth' })
                }
                console.log("Ingredienti scelti:", SelectedItems)
                console.log("Prezzi aggiuntivi:", AddedPrices)

            }
            break;
        case "Topping":
            if (SelectedItems.includes(id) == true || SelectedToppings.lenght >= 1) {
                alert("Ingrediente giá inserito")
            } else {
                SelectedItems.push(id)
                SelectedToppings.push(id)
                AddedPrices.push(Price)
                FotoIngrediente.classList.toggle("IngredienteInserito")
                if (SelectedToppings.length === 1) {
                    document.getElementById("SalseSection").scrollIntoView({ behavior: 'smooth' })
                }
                console.log("Ingredienti scelti:", SelectedItems)
                console.log("Prezzi aggiuntivi:", AddedPrices)
                
            }
            break;
        case "Salsa":
            if (SelectedItems.includes(id) == true || SelectedSalse.length >= 1) {
                alert("Ingrediente giá inserito")
            } else {
                SelectedItems.push(id)
                SelectedToppings.push(id)
                AddedPrices.push(Price)
                FotoIngrediente.classList.toggle("IngredienteInserito")
                console.log("Ingredienti scelti:", SelectedItems)
                console.log("Prezzi aggiuntivi:", AddedPrices)
            }
            break;
    }
    sessionStorage.setItem("Ingredienti", SelectedItems)
    sessionStorage.setItem("PrezziAggiuntivi", AddedPrices)
}

let removeFromPoke = function (id) {

    let FotoIngrediente = document.getElementById(id)
    let TipoIngrediente = FotoIngrediente.parentElement.getAttribute("type")

    switch (TipoIngrediente) {
        case "Base":
            if (SelectedItems.includes(id) == true) {
                let position1 = SelectedItems.indexOf(id)
                let position2 = SelectedBase.indexOf(id)
                SelectedItems.splice(position1, 1)
                AddedPrices.splice(position1, 1)
                SelectedBase.splice(position2, 1)
                FotoIngrediente.classList.toggle("IngredienteInserito")
            } else { alert("L'ingrediente selezionato non risulta inserito nella tua poké") }
            break
        case "Proteina":
            if (SelectedItems.includes(id) == true) {
                let position1 = SelectedItems.indexOf(id)
                let position2 = SelectedProteine.indexOf(id)
                SelectedItems.splice(position1, 1)
                AddedPrices.splice(position1, 1)
                SelectedProteine.splice(position2, 1)
                FotoIngrediente.classList.toggle("IngredienteInserito")
            } else { alert("L'ingrediente selezionato non risulta inserito nella tua poké") }
            break
        case "Contorno":
            if (SelectedItems.includes(id) == true) {
                let position1 = SelectedItems.indexOf(id)
                let position2 = SelectedContorni.indexOf(id)
                SelectedItems.splice(position1, 1)
                AddedPrices.splice(position1, 1)
                SelectedContorni.splice(position2, 1)
                FotoIngrediente.classList.toggle("IngredienteInserito")
            } else { alert("L'ingrediente selezionato non risulta inserito nella tua poké") }
            break
        case "Topping":
            if (SelectedItems.includes(id) == true) {
                let position1 = SelectedItems.indexOf(id)
                let position2 = SelectedToppings.indexOf(id)
                SelectedItems.splice(position1, 1)
                AddedPrices.splice(position1, 1)
                SelectedToppings.splice(position2, 1)
                FotoIngrediente.classList.toggle("IngredienteInserito")
            } else { alert("L'ingrediente selezionato non risulta inserito nella tua poké") }
            break
        case "Salsa":
            if (SelectedItems.includes(id) == true) {
                let position1 = SelectedItems.indexOf(id)
                let position2 = SelectedSalse.indexOf(id)
                SelectedItems.splice(position1, 1)
                AddedPrices.splice(position1, 1)
                SelectedSalse.splice(position2, 1)
                FotoIngrediente.classList.toggle("IngredienteInserito")
            } else { alert("L'ingrediente selezionato non risulta inserito nella tua poké") }
            break
    }
}





    

