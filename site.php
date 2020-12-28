<?php

    $paginas = ['FORÇA'=>'','FRAQUEZAS'=>' ',''=>' ','OPORTUNIDADES'=>' ','AMEAÇAS'=>' '];
    $paginas['FORÇA'] ='<img class="rt" align="right" src="marketing.webp">
    <h2>Segurança;<br><br>
    Qualidade de produtos e serviços prestados;<br><br>
    Marketing;<br><br>
    Reconhecimento da marca.</h2><br>';
    $paginas['FRAQUEZAS'] = '<img  class="tm" align="right" src="segurança.jpg">
    <h2>Falta de treinamento:Funcionários que precisam de mais treinamento;<br><br>
    Sistema desatualizado: Um sistema desatualizado pode gerar brechas na segurança e comprometer informações;<br><br>
    Escalabilidade frágil: torna um equipamento incapacitado de receber implementações tornando-o obsoleto não garantindo a segurança da qualidade do produto.<br><br></h2> ';
    $paginas['OPORTUNIDADES'] = '<img class="tr" align="right" src="oportunidades.jpg"> 
    <h2>Workshop para funcionários: Investir em capacitação para os mesmos trabalharem mais motivados;<br><br>
    Fidelização de clientes;<br><br>
    Premiação de funcionários;<br><br>
    Adaptação às novas tecnologias.</h2><br> ';
    $paginas['AMEAÇAS'] = '<img class="subt" align="right" src="blackhat.jpeg">
    <h2>Preço flutuante dos produtos;<br><br>
    Forte concorrência de outras marcas;<br><br>
    Turbulência do ambiente: As empresas nesse ambiente precisam sobreviver ao ambiente incerto de tecnologia. Onde existe uma rápida evolução das tecnologias;<br><br>
    Turbulências políticas: Brasil está muito instável, poucos investidores estão confiando.</h2><br> ';
?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="estilopix.css" rel="stylesheet" media="screen and(min-width:641px)"/>
    <link href="smarthphone.css" rel="stylesheet" media="screen and(max-width:640px)"/>
    <title>FATEC Guarulhos</title>
    <style type='text/css'>
        *{
            margin =0;
            padding =0;
            box-sizing: border-box;
        
         }
         body{
            height:100%;
            max-height:100vw;
            width:100%;
            max-width:170vh;
            background-image:url(digitalização.jpg);
            background-attachment:top;
            background-size:cover;
            background-repeat:no-repeat;
            background-color:black;
            color:black;
            min-width:300px;

         }

        header{
            max-width:100%;
            width:10pt 2pt;
            max-height:100%;
            height:10pt 2pt;
            padding-top:50px;
            text-align:justify;
            font-size:24px;
            color:white;
            margin:10px;
            padding-left:20px;
            top:20px;
            }

            a{
            font-family:arial;   
            text-align:justify;
            display:inline-block;
            color:white;
            margin:4px 6px;
            font-size:18px;
            padding-top:50px;
            margin-left:20px;
            margin-top:20px;
            max-width: 100%;
            }
        section{
            background-size:100% auto;
            margin:4px auto;
            }
        h2{
            display:inline;
            text-align:justify;
            color:white;
            font-size:arial 14px;
            padding-top:10px;
            }
               
        img.text{
            height:100%;
            max-height:180px;
            width:100%;
            max-width:150px;
            position:relative;
            }
        img.guaru{
            height:100%;
            max-height:80px;
            width:100%;
            max-width:100px;
            position:relative;
            left:156pt;
        
          }
          img.rt{
            position:relative;
            left:150pt;
            width:100%;
            max-width:400px;
            height:100%;
            max-height:275px;
            background-size:100% auto;
          }
          h3{
            color:white;
            font-family:cursive;
            font-size:14px;
            padding-top:500px
          }
          img.tm{
            position:relative;
            left:150pt;
            width:100%;
            max-width:420px;
            height:100%;
            max-height:380px;
            background-size:100% auto;
            font-size:26px;
          }
          img.tr{
            position:relative;
            left:160pt;
            width:100%;
            max-width:240pt;
            height:100%;
            max-height:200px;
            background-size:100% auto;
          }

          h1{

                display:inline-block;
                top:20px;
          }
          img.subt{
            position:relative;
            left:110pt;
            top:80pt;
            width:100%;
            max-width:300pt;
            height:100%;
            max-height:250px;
            background-size:100% auto;
          }


          

            
                </style>
    
         </head>
    <body>
<img class = "text" align="left" src="icone.webp"/>
<img class = "guaru" align="right" src="gua.jpg"/>
    <?php
        foreach($paginas as $key => $value){

        echo '<a href="?page='.$key.'">'.ucfirst($key).'</a>';}
        ?>

    <header>
        <section>

            <h2><?php

                $pagina = (isset($_GET['page']) ? $_GET['page'] : ' ');
                
                if(!array_key_exists($pagina, $paginas)){
                    $pagina = 'FORÇA';
                }
               
            ?></h2>

            <p><?php echo $paginas[$pagina];?></p>
        </section>
                
    </header>
    </body>
</html>
<marquee><h3>SEJA MUITO BEM-VINDO...APROVEITE BEM NOSSO SITE,FEITO COM MUITO CARINHO PARA VOCÊS ESTUDANTES DO CURSO DE ADS</h3> </marquee>