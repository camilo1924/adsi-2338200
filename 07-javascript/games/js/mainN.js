//Variables

let tarjetasDestapadas  = 0
let tarjeta1            = null
let tarjeta2            = null
let primerResultado     = null
let segundoResultado    = null
let movimientos         = 0
let aciertos            = 0
let temporizador        = false
let timer               = 30
let timerInicial        = timer
let tiempoRegresivoId   = null
// Apuntando adocumentoo html
let msotrarMovimientos  = document.getElementById('movimientos')
let msotrarAciertos     = document.getElementById('aciertos')
let mostrarTiempo       = document.getElementById('t-restante')
let restartButton       = document.querySelector('.reset')

let winAudio   = new Audio('../sounds/win.wav')
let loseAudio  = new Audio('../sounds/lose.wav')
let clickAudio = new Audio('../sounds/click.wav')
let rightAudio = new Audio('../sounds/right.wav')
let wrongAudio = new Audio('../sounds/wrong.wav')

// Gewneracion numeros aleatoorioos
let numeros = [1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8]
numeros = numeros.sort(()=>{
    return Math.random()-0.5
});
console.log(numeros)

//Funciones

restartButton.addEventListener('click', (e) =>{
    window.location.reload()
})
function contarTiempo(){
    tiempoRegresivoId = setInterval(()=>{
        timer--;
        mostrarTiempo.innerHTML = `Tiempo: ${timer}S`
        if(timer == 0){
            clearInterval(tiempoRegresivoId)
            bloquearTarjetas()
            loseAudio.play();
            Swal.fire('Game Over')
        }
    },1000);
}

function bloquearTarjetas(){
    for (let i = 0; i <= 15; i++) {
        let tarjetaBloqueada = document.getElementById(i);
        tarjetaBloqueada.innerHTML = numeros[i];
        tarjetaBloqueada.disabled = true;
    }
}

//Function
function destapar(id) {
    //Temporizador

    if((temporizador == false)){
        contarTiempo();
        temporizador = true
    }

    tarjetasDestapadas++;
    console.log(tarjetasDestapadas);
    
    if(tarjetasDestapadas == 1){
        // Mostrar primer numbero
        tarjeta1 = document.getElementById(id);
        primerResultado = numeros[id]
        tarjeta1.innerHTML = primerResultado;
        clickAudio.play();

        //Detener primer boton
        tarjeta1.disabled = true
    }else if(tarjetasDestapadas == 2){
        //Mostrar segundo numero
        tarjeta2 = document.getElementById(id);
        segundoResultado = numeros[id];
        tarjeta2.innerHTML = segundoResultado

        //desactivar 2 boton
        tarjeta2.disabled = true

        //Incrementar movimientos
        movimientos++;
        msotrarMovimientos.innerHTML = `Movimientos: ${movimientos}`;

        if(primerResultado == segundoResultado){
            // Encerar contadoor tarjetas destapadas
            tarjetasDestapadas = 0;

            //Aumentar aciertoos
            aciertos++;
            msotrarAciertos.innerHTML = `Aciertos: ${aciertos}`
            rightAudio.play();

            if(aciertos == 8){
                winAudio.play();
                clearInterval(tiempoRegresivoId);
                Swal.fire(msotrarAciertos.innerHTML = `Aciertos: ${aciertos} 💯`,
                mostrarTiempo.innerHTML = `Felicidades tu tiempo fue de: ${timerInicial - timer} 💯`,
                msotrarMovimientos.innerHTML = `Movimientos: ${movimientos} 💯`)
            }

        }else{
            wrongAudio.play();
            //Mostrar momentaniamente y volver a tapar valoroes
            setTimeout(()=>{
                    tarjeta1.innerHTML = ' ';
                    tarjeta2.innerHTML = ' ';
                    tarjeta1.disabled = false;
                    tarjeta2.disabled = false;
                    tarjetasDestapadas = 0;
            },800);
        }
    }

}