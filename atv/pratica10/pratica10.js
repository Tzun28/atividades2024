let taxas = [
    { origem: "R$", destino: "$", taxa: 0.19 },
    { origem: "R$", destino: "€", taxa: 0.16 },
    { origem: "R$", destino: "ARS", taxa: 0.81 },
    { origem: "$", destino: "R$", taxa: 5.25 },
    { origem: "€", destino: "R$", taxa: 6.21 },
    { origem: "£", destino: "R$", taxa: 7.08 },
    { origem: "ARS", destino: "R$", taxa: 0.81 },
];

function encontrarTaxa(origem, destino) {
    for (let i = 0; i < taxas.length; i++) {
        if (taxas[i].origem === origem && taxas[i].destino === destino) {
            return taxas[i].taxa;
        }
    }
    return null;
}

function converterMoeda() {
    let valor = parseFloat(document.getElementById('valor').value);
    let origem = document.getElementById('origem').value;
    let destino = document.getElementById('destino').value;

    if (isNaN(valor) || valor <= 0) {
        alert("Por favor, insira um valor válido.");
        return;
    }

    let taxa = encontrarTaxa(origem, destino);
    if (taxa === null) {
        alert("Conversão não disponível para essas moedas.");
        return;
    }

    let valorConvertido = valor * taxa;

    document.getElementById('resultado').innerHTML = 
        `Valor convertido: ${valor.toFixed(2)} ${origem} = ${valorConvertido.toFixed(2)} ${destino}<br>
        Cotação: 1 ${origem} = ${taxa.toFixed(2)} ${destino}`;
}
