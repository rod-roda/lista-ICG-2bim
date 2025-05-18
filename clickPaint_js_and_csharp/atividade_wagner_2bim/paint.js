/** Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: DD/MM/2020
 * Autores do Projeto: Rodrigo Roda Oliveto Alves
 *                     Thiago César Carvalho
 *                     Thiago Alexander Moreira Mancilla
 *                     Natan Soares Telles
 *   
 * Turma: 3H
 * Atividade Proposta em aula
 * ******************************************************************/

const canvas = document.getElementById("canvas");
const ctx = canvas.getContext("2d");
canvas.width = 1920;
canvas.height = 1080;

const input_espessura = document.getElementById("espessura");
const input_altura = document.getElementById("altura");
const input_largura = document.getElementById("largura");
const label_funcao = document.getElementById("labelFuncao");
const label_compirmento = document.getElementById("labelComprimento");

let point = [];
let click = false;
let retangulo_bool = false;
let altura, largura = 0;

canvas.addEventListener('click', function(event) {
    const rect = canvas.getBoundingClientRect();
    
    let espessura = input_espessura.value;
    altura = parseInt(input_altura.value);
    largura = parseInt(input_altura.value);

    if(!click){
        click = true;

        point[0] = event.clientX - rect.left;
        point[1] = event.clientY - rect.top;

        if(altura != null && largura != null){
            ctx.clearRect(0, 0, canvas.width, canvas.height);
            retangulo_bool = true;
            paint();
        }
    }else{
        ctx.clearRect(0, 0, canvas.width, canvas.height);
        click = false;
        point[2] = event.clientX - rect.left;
        point[3] = event.clientY - rect.top;
        
        ctx.lineWidth = espessura;
        paint();
    }
});

function definirCor(texto_cor){
    return cor = texto_cor;
}

function desenharReta(x1, y1, x2, y2, cor){
    ctx.beginPath();
    ctx.strokeStyle = cor;
    ctx.moveTo(x1, y1);
    ctx.lineTo(x2, y2);
    ctx.stroke();
}

function estiloReta(estilo, espessura){
    ctx.setLineDash(estilo);
    ctx.lineWidth = espessura;
}

function retangulo(x0, y0, x1, y1, cor) {
    desenharReta(x0, y0, x1, y0, cor);
    desenharReta(x1, y0, x1, y1, cor);
    desenharReta(x1, y1, x0, y1, cor);
    desenharReta(x0, y1, x0, y0, cor);
}

function equacaoDaReta(point) {
    if (point[0] === point[2]) {
        return `x = ${point[0]}`;
    }

    const m = (point[3] - point[1]) / (point[2] - point[0]);
    const b = point[1] - m * point[0];

    const mStr = m.toFixed(2).replace(/\.?0+$/, ''); // remove zeros desnecessários
    const bAbs = Math.abs(b).toFixed(2).replace(/\.?0+$/, '');
    const bStr = b >= 0 ? `+ ${bAbs}` : `- ${bAbs}`;

    return `f(x) = ${mStr}x ${bStr}`;
}

function comprimentoReta(point) {
    const dx = point[2] - point[0];
    const dy = point[3] - point[1];
    return Math.sqrt(Math.pow(dx, 2) + Math.pow(dy, 2));
}

function paint(){
    //estiloReta([10, 5], 1);
    if(!retangulo_bool){
        desenharReta(point[0], point[1], point[2], point[3], definirCor("rgb(255,0,0)"));
        label_funcao.innerText = "Função da reta: " + equacaoDaReta(point);
        label_compirmento.innerText =  "Comprimento da Reta: " + comprimentoReta(point).toFixed(2) + "px";
    }
    else{
        retangulo_bool = false;
        retangulo(point[0], point[1], point[0] + largura, point[1] + altura, definirCor("rgb(255,0,0)"));
    }
}