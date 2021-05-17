
let esquerda = "left";
let direita = "right";
let baixo = "down";
let cima = "up" ;

let canvas = document.getElementById("snake");
let context = canvas.getContext("2d");
let box = 32;
let snake = [];
snake[0] = 
{
    x:8 * box,
    y:8 * box
}
let direction = direita;

let food = 
{
    x: Math.floor(Math.random() * 15 + 1) * box,
    y: Math.floor(Math.random() * 15 + 1) * box
}

//Contexto renderiza a imagem

function criarBG()
{
    context.fillStyle = "white";
    //Desenha a área do game
    context.fillRect(0, 0, 16 * box, 16 * box);
}

function criarCobrinha()
{
    for(i=0; i < snake.length;i++)
    {
        context.fillStyle = "blue";
        context.fillRect(snake[i].x,snake[i].y, box, box);
    }
}

function drawfood()
{
    context.fillStyle = "red";
    context.fillRect(food.x, food.y, box, box);
}

document.addEventListener('keydown',update);

function update(event)
{
    if(event.keyCode == 37 && direction != direita)
        direction = esquerda;
    if(event.keyCode == 38 && direction != baixo)
        direction = cima;
    if(event.keyCode == 39 && direction != esquerda)
        direction = direita;
    if(event.keyCode == 40 && direction != cima)
        direction = baixo;
}

function startGame()
{
    //Se a cobra encostar em si mesma o jogo acaba
    for(i = 1; i < snake.length;i++)
    {
        if(snake[0].x == snake[i].x && snake[0].y == snake[i].y)
        {
            clearInterval(game);
            alert('Game over');
            window.location.reload();
        }
    }

    if(snake[0].x > 15 * box && direction == "right")
        snake[0].x = 0;
    if(snake[0].x < 0 && direction == "left")
        snake[0].x = 16 * box;
    if(snake[0].y > 15 * box && direction == "down")
        snake[0].y = 0;
    if(snake[0].y < 0 && direction == "up")
        snake[0].y = 16 * box;

    criarBG();
    criarCobrinha();
    drawfood();

    //Muda para a posição inicial
    let positionX =  snake[0].x;
    let positionY =  snake[0].y;

    //Criando coordenadas
    if(direction == "right")
        positionX += box;
    if(direction == "left")
        positionX -= box;
    if(direction == "up")
        positionY -= box;
    if(direction == "down")
        positionY += box;

    if(positionX != food.x || positionY != food.y)
    {
        snake.pop();
    }
    else
    {
        food.x = Math.floor(Math.random() * 15 + 1) * box;
        food.y = Math.floor(Math.random() * 15 + 1) * box;
    }

    let newHead = 
    {
        x: positionX,
        y: positionY
    }

    snake.unshift(newHead);
}
let game = setInterval(startGame, 100);