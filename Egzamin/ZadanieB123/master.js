// Odpowiednie uchwyty elementów htmla
var numb1 = document.getElementById("firstNumber");
var numb2 = document.getElementById("secondNumber");
var output = document.getElementById("result");
var button = document.getElementById("buttonSum");
var start = document.getElementById("buttonStartTimer");
var counterLabel = document.getElementById("counterLabel");
//Zmienna przechowująca czas
let i = 1;
// Funkcja sumująca dwie liczby
function sumTwoNumbers()
{
    let sum = parseFloat(numb1.value) + parseFloat(numb2.value);
    return sum;
}
// Funkcja odpowiedzialna za zmianę koloru
function change()
{
    clearInterval(countdown);
    document.getElementById("content").style.backgroundColor = `rgb(200,200,100)`;
}

// Obsługa przycisku sumującego dwie liczby
button.addEventListener('click', function()
{
    output.value = sumTwoNumbers();
})

// Obsługa przycsku uruchamiającego timer
start.addEventListener('click', function()
{
    i=0;
    countdown =  setInterval(function()
    {
        i++;
        counterLabel.textContent = i;
        if(i==9)
        {
            change();
        }
    },3000);
})