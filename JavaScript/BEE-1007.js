var input = require("fs").readFileSync("stdin", "utf8");

var valores = input.split("\n");

var a = parseInt(valores.shift());
var b = parseInt(valores.shift());
var c = parseInt(valores.shift());
var d = parseInt(valores.shift());

var diferenca = a * b - c * d;

console.log("DIFERENCA = " + diferenca);