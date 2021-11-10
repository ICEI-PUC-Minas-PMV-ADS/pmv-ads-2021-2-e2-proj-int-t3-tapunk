# Programação de Funcionalidades

Nesta seção é apresentada a tela Home-Page e apenas uma das funcionalidades do sistema. O respectivo endereço (URL) e outras orientações de acesso são apresentadas na sequência. 

## Visualização da tela de Home-Page

A tela principal apresenta diversas funcionalidades que estarão descritas separadamente nas próximas visualizações de telas, na Home-Page temos estruturas de dados baseada em HMTL e CSS. Exemplo da tela Home-Page:

![tela de Home-Page](/img/tela_home_page.png)

### Artefatos da funcionalidade 

*index.html
*adicionarequipe.html
*adicionarevento.html
*vejaMais.html
*style.css

### Estrutura de Dados 
 
 <main>
    <section id="banners-promocionais" class="container carousel slide" data-ride="carousel">
      <article class="carousel-inner">
        <figure class="carousel-item active">
          <img src="./assets/images/fotocarrouselarrumada.jpg" class="d-block w-100"
            alt="Foto de uma equipe de Airsoft">
        </figure>
        <figure class="carousel-item">
          <img src="./assets/images/fotocarrouselarrumada2.jpg" class="d-block w-100"
            alt="Foto de uma equipe de Airsoft">
        </figure>
      </article>
      <a class="carousel-control-prev" href="#" role="button" data-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
      </a>
      <a class="carousel-control-next" href="#" role="button" data-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
      </a>
    </section>
    <section class="container banners-promocionais-statico">
      <section class="row">
        <article class="col-md-6">
          <div class="banners-promocionais-statico-12x d-flex align-items-center">
            <a href="adicionarevento.html">
              <p>Criar Eventos</p>
          </div>
        </article>
        <article class="col-md-6">
          <div class="banners-promocionais-statico-todo-br d-flex align-items-center">
            <a href="adicionarequipe.html">
              <p>Adicionar Equipes</p>
          </div>
        </article>
      </section>
    </section>
    <section class="container produtos">
      <h1 class="text-center">Ranking Nacional</h1>
      <article class="row">
        <a class="produtos-container col-md-3">
          <img src="./assets/images/painel1.jpeg" class="img-fluid" alt="Black River Airsoft">
          <article class="ranking">
            <h2>Black River Airsoft</h2>
            <strong class="colocacao">
              <img src="./assets/images/1lugar.png" alt="primeiro lugar">
              1º Lugar
            </strong>
          </article>
        </a>
        <a class="produtos-container col-md-3">
          <img src="./assets/images/painel2.jpeg" class="img-fluid" alt="Esquadrão Tatico Airsoft">
          <article class="ranking">
            <h2>Esquadrão Tatico Airsoft</h2>
            <strong class="colocacao">
              <img src="./assets/images/2lugar.png" alt="segundo lugar">
              2º Lugar
            </strong>
          </article>
        </a>
        <a class="produtos-container col-md-3">
          <img src="./assets/images/painel4.jpeg" class="img-fluid" alt="Assault Squad Airsoft">
          <article class="ranking">
            <h2>Assault Squad Airsoft</h2>
            <strong class="colocacao">
              <img src="assets/images/3lugar.png" alt="terceiro lugar">
              3º Lugar
            </strong>
          </article>
        </a>
      </article>
      <div class="d-flex justify-content-center">
        <a href="/vejaMais.html" class="btn btn-warning col-md-2">VEJA MAIS</a>
      </div>
    </section>
  </main>


### Instruções de acesso 

1.	Abra um navegador de Internet e informe a URL https://vigilant-curran-675f62.netlify.app/ 
2.	Abrirá a página inicial do site.


## Visualização da tela de Login (RF-01)

O acesso a tela de Login poderá ser realizado nas demais telas do sistema através do menu “Entrar”, as estruturas dados foram baseadas em HMTL e CSS. Exemplo da tela Login:

![tela de Login](/img/tela_login1.png)

### Requisitos atendidos 

*RF-01  


### Artefatos da funcionalidade 

*login.html

*style.css

### Estrutura de Dados 

     <main class="container">
    <h1 class="d-flex justify-content-center"><strong>LOGIN</strong></h1>
    <article class="row d-flex align-items-center">
      <form action="">
        <div class="email">
          <label>E-mail</label>
          <input type="email" name="email" id="email" required placeholder="Digite seu E-mail">
          <div class="underline"></div>
        </div>
        <div class="senha">
          <label>Senha</label>
          <input type="password" name="Senha" id="Senha" required placeholder="Digite sua senha">
          <div class="underline"></div>
        </div>
        <div class="d-flex justify-content-center">
          <input onclick="verificarCliente()" type="submit" value="Entrar">
        </div>
        <div class="d-flex bd-highlight mb-1">
          <div class="mr-auto p-2 bd-highlight">
            <a class="container-fluid" href="cadastro.html" id="resgiter-container">Cadastre-se</a>
          </div>
          <div class="p-2 bd-highlight">
            <a class="container-fluid" href="#" id="forgot-pass">Esqueceu a senha?</a>
          </div>
        </div>
      </form>
    </article>
  </main>

### Instruções de acesso 

1.	Abra um navegador de Internet e informe a URL https://vigilant-curran-675f62.netlify.app/ 
2.	No canto superior esquerdo da tela, clica em entrar, onde o usuário é redirecionado para a tela de login essa é a primeira funcionalidade exibida pelo site.


## Visualização da tela de Cadastro (RF-02)

Em todas as telas será possível o usuário realizar o cadastro, a estruturas de dados utilizada foi baseada em HMTL e CSS. Exemplo da tela Cadastro: 

![tela de Cadastro](/img/tela_cadastro1.png)

### Requisitos atendidos 

*RF-02

### Artefatos da funcionalidade 

*cadastro.html

*style.css

 
### Estrutura de Dados 

 <main class="cadastro">
    <section class="container produtos">
      <h2 class="d-flex justify-content-center">CADASTRO DO USUÁRIO</h2>
      <div class="figure-cadequipe row justify-content-between">
        <figure class="figure-adicionar col-md-3">
          <img src="assets/images/adicionar-img.PNG"
            class="imagem4 figure-img img-fluid col-xl-10 col-lg-10 col-md-12 nav-item d-flex align-items-center"
            alt="caixa para adicionar equipe">
          <figcaption class="figure-caption text-center">Adicione uma imagem</figcaption>
        </figure>
        <form class="form_equipe col-md-8" method="post" id="formulario" action="#">
          <fieldset id="dados">
            <p><label for="nome">Nome:</label><input type="text" name="tnome" id="nome" size="40" required
                class="text-left"></p>
            <p><label for="apelido">Apelido: </label><input type="text" name="tapelido" id="apelido" size="39" required>
            </p>
            <p><label for="nasc">Data de Nasc: </label><input type="date" name="tnasc" id="nasc"></p>
            <label for="sexo">Sexo:</label><select name="" id="sexo">
              <option selected disabled value="">Selecione</option>
              <option value="">Masculino</option>
              <option value="">Feminino</option>
            </select>
            <p><label for="email">Email: </label><input type="email" name="tmail" id="email" size="41" required></p>
            <p><label for="pais">Pais: </label><input type="text" name="tpais" id="pais" size="40"></p>
            <p><label for="cidade">Cidade: </label>
              <input type="text" name="tcid" id="cidade" size="40">
            </p>
            <p><label for="uf">UF</label>
              <select name="uf" id="uf" required>
                <option value="SP">SP</option>
                <option value="RJ">RJ</option>
                <option value="MG">MG</option>
                <option value="GO">GO</option>
                <option value="SC">SC</option>
                <option value="PR">PR</option>
              </select>
            </p>
          </fieldset>
          <p><label for="modal">Pratica qual modalidade: </label>
            <select name="select" id="modalselect">
              <option selected disabled value="">Escolha</option>
              <option value="SK">Skirmish</option>
              <option value="MI">Milsim</option>
              <option value="DM">Deathmatch</option>
              <option value="CB">Capture the Flag</option>
              <option value="MH">Man Hunt</option>
              <option value="HT">Hostage</option>
            </select>
          </p>
          <p><label>Operador desde: <input type="date" name="Odata" id="odata"></label></p>
          <fieldset id="links">
            <p><label for="site">Site: </label><input type="text" name="tsite" id="site" size="40"></p>
            <p><label for="facebook">Facebook: </label><input type="text" name="tface" id="facebook" size="40"></p>
            <p><label for="youtube">Youtube: </label><input type="text" name="tyou" id="youtube" size="40"></p>
            <p><label for="instagran">Instagram: </label><input type="text" name="tinst" id="instagran" size="40"></p>
            <p><label for="twitter">Twitter: </label><input type="text" name="ttwit" id="twitter" size="40"></p>
            <p><label for="g+">G+ Google+: </label><input type="text" name="g+" id="googlemais" size="40"></p>
          </fieldset>
          <div class="d-flex justify-content-center">
            <button type="submit" name="botao" id="botao" class=" col-md-5 text-center ">CADASTRAR</button>
          </div>
        </form>
      </div>
    </section>
  </main>

### Instruções de acesso  

1.	Abra um navegador de Internet e informe a URL https://vigilant-curran-675f62.netlify.app/ 
2.	No canto superior à direita da tela, clicar no menu “cadastro”, onde o usuário é redirecionado para a tela de cadastro.
3.	Na tela de cadastro ele irá preencher as lacunas conforme requisitado pelo site.


## Visualização da tela Eventos Disponíveis (RF-08/05)

Em todas as telas será possível o usuário acessa a tela de “Eventos Disponíveis”, a estruturas de dados utilizada foi baseada em HMTL e CSS. Exemplo da tela Eventos Disponíveis:

![tela Eventos Disponíveis](/img/tela_eventosdisponiveis.png)

### Requisitos atendidos 

*RF-08

*RF-05

### Artefatos da funcionalidade 

*eventosDisponiveis.html

*style.css
  
### Estrutura de Dados 

    <main class="container-eventos">
    <section class="container produtos">
      <article>
        <h2 class="d-flex justify-content-center">EVENTOS DISPONÍVEIS</h2>

        <div class="conteudo-eventos1 row justify-content-between">
          <figure class="figure col-md-5">
            <img src="assets/images/googlemapevento.jpeg"
              class="imagem3 figure-img img-fluid col-xl-10 col-lg-10 col-md-12 nav-item d-flex align-items-center"
              alt="imagem do mapa do do local do evento">
          </figure>
          <div class="texto1 col-sm-7">
            <p> <strong>Airsoft Day</strong><br /> Evento das melhores equipes
              em São Paulo,venha e se junte a nós nesta
              aventura. Será na região de Mogi das Cruzes no dia 01/10/2021 ás
              08h00 encontre uma equipe ou traga a sua.</p>
            <div class="d-flex justify-content-center">
              <button type="submit" name="botao" id="botao" value="enviar"> Clique aqui para participar desse
                evento</button>
            </div>
          </div>
        </div>

        <div class="conteudo-eventos2 row justify-content-between">
          <figure class="figure col-md-5">
            <img src="assets/images/googlemapevento.jpeg"
              class="imagem3 figure-img img-fluid col-xl-10 col-lg-10 col-md-12 nav-item d-flex align-items-center"
              alt="imagem do mapa do do local do evento">
          </figure>
          <div class="texto2 col-sm-7">
            <p> <strong>Batalha de Airsoft</strong><br /> Não perca esta
              oportunidade de explorar suas emoções, se cadastre e venha pra ZL. Parque do Carmo em Itaquera - SP dia
              01/11/2021 as 10h.</p>
            <div class="d-flex justify-content-center">
              <button type="submit" name="botao" id="botao" value="enviar"> Clique aqui para participar desse
                evento</button>
            </div>
          </div>
        </div>
        <div class="conteudo-eventos3 row justify-content-between">
          <figure class="figure col-md-5">
            <img src="assets/images/googlemapevento.jpeg"
              class="imagem3 figure-img img-fluid col-xl-10 col-lg-10 col-md-12 nav-item d-flex align-items-center"
              alt="imagem do mapa do do local do evento">
          </figure>
          <div class="texto3 col-sm-7">
            <p><strong>MovAirsoft</strong> <br />Antes de iniciar como jogador,
              é importante estar atento a algumas dicas importantes.Separamos algumas dicas para te ajudar, venha
              participar do nosso evento e fazer parte
              desta aventura. Ibiapuera SP dia 25/12/2021 ás 09h30.</p>
            <div class="d-flex justify-content-center">
              <button type="submit" name="botao" id="botao" value="enviar"> Clique aqui para participar desse
                evento</button>
            </div>
          </div>
        </div>
    </section>
    </article>
  </main>

### Instruções de acesso 

1.	Abra um navegador de Internet e informe a URL https://vigilant-curran-675f62.netlify.app/ 
2.	No menu de navegação abaixo do logo em todas as telas, ao clicar no menu “eventos”, onde o usuário é redirecionado para a tela de eventos disponíveis.
3.	Na tela de eventos disponíveis ele irá ter acesso aos eventos de Airsoft disponíveis naquele momento.


## Visualização da tela informações Sobre Airsoft (RF- 06) 

Em todas as telas será possível o usuário acessa a tela de “Sobre Airsoft”, a estruturas de dados utilizada foi baseada em HMTL e CSS. Exemplo da tela Sobre Airsoft: 

![tela informações Sobre Airsoft](/img/tela_sobre.png)

### Requisitos atendidos 

*RF-06

### Artefatos da funcionalidade 

*sobreAirsoft.html

*style.css

### Estrutura de Dados 

 <main class="container-sobre">
    <section class="container produtos">
      <article>
        <div class="conteudo">
          <div class="texto">
            <h2>O que é Airsoft?</h2>
            <p>O Airsoft é um esporte de simulação de combates de guerra...lógico.<br>
            </p>
            <h3>Qual a estrutura e regras do jogo?</h3>
            <p>A base do Airsoft é a divisão de equipes. Os jogadores são...de entrar no campo.</p>
            <div class="imagem1 col-md-8">
              <img src="./assets/images/imagem-sobre1.png" class="img-fluid">
            </div>
            <h3>Modalidade Skirmish</h3>
            <p>Para quem joga a modalidade Skirmish, por exemplo, não há ... com a monotonia e longas horas de uma partida convencional.</p>
            <h3>Modalidade MilSim</h3>
            <p>Entretanto, para quem joga MilSim — Simulação Militar, em uma tradução livre —, tudo muda ... muitas variações e que consegue agregar (e agradar) um grande número de participantes.</p>
            <h3>Onde praticar?</h3>
            <p>A legislação brasileira não é clara a respeito de qual seria o ... entre outros. Esses, ambientes oferecem muitas possibilidades de esconderijo.</p>
            <h3>Quais são as leis?</h3>
            <p>Lembrando que a legislação brasileira implica que os participantes devem ter obrigatoriamente 18 anos de... proibida a pintura posterior dessas regiões do equipamento.</p>
            <h3>Quais os equipamentos de segurança?</h3>
            <p>A prática segura do Airsoft depende dos equipamentos ... uma partida pode durar muito tempo, a exposição ao sol por muitas horas pode causar problemas.</p>
            <h3>Quanto custa?</h3>
            <p>Para iniciar a prática, o equipamento completo (armas e proteções ... mercado, que melhoram a experiência do esporte.</p>
            <h3>Como é a prática de Airsoft no Brasil?</h3>
            <p>O Airsoft é regulado e permitido no Brasil desde 2003 ... o esporte é uma bela pedida!</p>
          </div>
        </div>
    </section>
    </article>
  </main>

### Instruções de acesso 

1.	Abra um navegador de Internet e informe a URL https://vigilant-curran-675f62.netlify.app/ 
2.	No menu de navegação abaixo do logo em todas as telas, ao clicar no menu “Sobre”, onde o usuário é redirecionado para a tela de sobre.
3.	Na tela de sobre ele irá ter acesso às informações sobre Airsoft.


## Visualização da tela Criar Eventos (RF-04)  

Na tela da home-Page será possível o usuário acessa a tela de “Criar Eventos”, a estruturas de dados utilizada foi baseada em HMTL e CSS. Exemplo da tela Criar Eventos:

![tela Criar Eventos](/img/tela_criarevento.png)

### Requisitos atendidos 

*RF-04

### Artefatos da funcionalidade 

*adicionarevento.html

*style.css


### Estrutura de Dados 

<main class="cadevent">
    <section class="container produtos">
      <h2 class="d-flex justify-content-center">ADICIONE SEU EVENTO</h2>
      <img src="assets/images/googlemapevento.jpeg" alt="fotocriaevent"
        class="fotoevent img-fluid d-flex justify-content-center">
      <div class="formulario">
        <form method="post" id="formulario" action="#">
          <fieldset id="dados">
            <p><label for="event">Data: </label><input type="date" name="teven" id="event"></p>
            <p><label for="pais">Pais: </label><input type="text" name="tpais" id="pais" size="20" required></p>
            <p><label for="cidade">Cidade: </label><input type="text" name="tcid" id="cidade" size="40"></p>
            <p><label for="uf">UF</label>
              <select name="uf" id="uf" required>
                <option value="SP">SP</option>
                <option value="RJ">RJ</option>
                <option value="MG">MG</option>
                <option value="GO">GO</option>
                <option value="SC">SC</option>
                <option value="PR">PR</option>
              </select>
            </p>
            <p><label for="ender">Endereço:</label><input type="text" name="tender" id="ender" size="20"></p>
          </fieldset>
          <p><label for="tipoeve">Tipo do Evento: </label>
            <select name="select" id="tipoeve">
              <option selected disabled value="">Escolha</option>
              <option value="SK">Skirmish</option>
              <option value="MI">Milsim</option>
              <option value="DM">Deathmatch</option>
              <option value="CB">Capture the Flag</option>
              <option value="MH">Man Hunt</option>
              <option value="HT">Hostage</option>
            </select>
          </p>
          <label for="descr">Descrição do Evento</label>
          <textarea name="descr" id="descr" cols="50" rows="10"></textarea>
          <div class="d-flex justify-content-center">
            <button type="submit" name="botao" id="botao" value="enviar">CADASTRAR</button>
          </div>
        </form>
      </div>
    </section>
  </main>

 
### Instruções de acesso 

1.	Abra um navegador de Internet e informe a URL https://vigilant-curran-675f62.netlify.app/ 
2.	No corpo do site ao clicar no botão “Criar eventos”, onde o usuário é redirecionado para a tela de Criar Eventos.
3.	Nesta tela ele irá preencher as lacunas conforme requisitado pelo site.


## Visualização da tela Adicionar Equipes (RF- 03) 

Na tela da home-Page será possível o usuário acessa a tela de “Adicionar equipes”, a estruturas de dados utilizada foi baseada em HMTL e CSS. Exemplo da tela adicionar equipes:

![tela Adicionar Equipes](/img/tela_adicionarequipe.png)

### Requisitos atendidos 

*RF-03

### Artefatos da funcionalidade 

*adicionarequipe.html

*style.css

### Estrutura de Dados 

  <main class="cad_equipe">
    <section class="container produtos">
      <h2 class="d-flex justify-content-center">CRIE SUA EQUIPE</h2>
      <div class="figure-cadequipe row justify-content-between">
        <figure class="figure-adicionar col-md-3">
          <img src="assets/images/adicionar-img.PNG"
            class="imagem4 figure-img img-fluid col-xl-10 col-lg-10 col-md-12 nav-item d-flex align-items-center"
            alt="caixa para adicionar equipe">
          <!-- <input type="file" id="fileimage"/> -->
          <figcaption class="figure-caption text-center">Adicione uma imagem</figcaption>
        </figure>
        <form class="form_equipe col-md-8" method="post" action="#">
          <fieldset id="dados">
            <p><label for="team_name">Nome da equipe: </label><input type="text" name="tname" id="team_name" size="40">
            </p>
            <p><label for="pais">Pais:</label><input type="text" name="tpais" id="pais"></p>
            <p><label for="uf">UF</label>
              <select name="uf" id="uf" required>
                <option value="SP">SP</option>
                <option value="RJ">RJ</option>
                <option value="MG">MG</option>
                <option value="GO">GO</option>
                <option value="SC">SC</option>
                <option value="PR">PR</option>
              </select>
            </p>
            <p><label for="cidade">Cidade: </label><input type="text" name="tcid" id="cidade" size="40"></p>
            <label for="team_members">Membros da equipe:</label><input type="text" name="tmembers" id="team_members"
              size="40">
            <p><label for="team_members"></label> </label><input type="text" name="tmembers" id="team_members"
                size="40">
            <p><label for="team_members"></label></label><input type="text" name="tmembers" id="team_members" size="40">
            </p>
            <p><label for="team_members"></label></label><input type="text" name="tmembers" id="team_members" size="40">
            </p>
            <p><label for="team_members"></label></label><input type="text" name="tmembers" id="team_members" size="40">
            </p>
            <p><label for="team_members"></label></label><input type="text" name="tmembers" id="team_members" size="40">
            </p>
            <p><label for="team_members"></label></label><input type="text" name="tmembers" id="team_members" size="40">
            </p>
            <p><Label for="team_history">História da equipe:</Label>
              <textarea name="caixa" id="team_history" cols="50" rows="10" maxlength="300" minlength="20"></textarea>
            </p>
          </fieldset>
          <div class="d-flex justify-content-center">
            <button type="submit" name="botao" id="botao" value="enviar">CADASTRAR</button>
          </div>
        </form>
      </div>
    </section>
  </main>


### Instruções de acesso 

1.	Abra um navegador de Internet e informe a URL https://vigilant-curran-675f62.netlify.app/ 
2.	No corpo do site ao clicar no botão “Adicionar Equipe”, onde o usuário é redirecionado para a tela de Adicionar equipe.
3.	Nesta tela ele irá preencher as lacunas conforme requisitado pelo site.


## Visualização da tela Veja Mais (RF- 07)  

Na tela principal do sistema apresenta um menu com “veja mais” que redireciona para a tela de ranking nacional das demais equipes cadastradas, utilizado estruturas de dados baseada em HMTL e CSS. Um exemplo da tela Veja Mais vagas: 

![tela Veja Mais](/img/tela_vejaMais.png)

### Requisitos atendidos 

*RF-07

### Artefatos da funcionalidade 

*vejaMais.html

*style.css


### Estrutura de Dados 

 <main>
 <section class="container produtos">
      <h1 class="d-flex justify-content-center">RANKING NACIONAL POR EQUIPES</h1>
      <article class="row">
        <a class="produtos-container col-md-3">
          <img src="./assets/images/painel1.jpeg" class="img-fluid" alt="Black River Airsoft">
          <article class="ranking">
            <h2>Black River Airsoft</h2>
            <strong class="colocacao row-cols-md-5">
              <img src="assets/images/1lugar.png" class="img-fluid" alt="primeiro lugar">
              1º Lugar
            </strong>
          </article>
        </a>
        <a class="produtos-container col-md-3">
          <img src="./assets/images/painel2.jpeg" class="img-fluid" alt="Camiseta manga comprida">
          <article class="ranking">
            <h2>Esquadrão Tatico Airsoft</h2>
            <strong class="colocacao">
              <img src="assets/images/2lugar.png" class="img-fluid" alt="primeiro lugar">
              2º Lugar
            </strong>
          </article>
        </a>
        <a class="produtos-container col-md-3">
          <img src="./assets/images/painel4.jpeg" class="img-fluid" alt="Camiseta listrada">
          <article class="ranking">
            <h2>Assault Squad Airsoft</h2>
            <strong class="colocacao">
              <img src="assets/images/3lugar.png" class="img-fluid" alt="primeiro lugar">
              3º Lugar
            </strong>
          </article>
        </a>
        <a class="produtos-container col-md-3">
          <img src="./assets/images/painel3.jpeg" class="img-fluid" alt="Saia plisada">
          <article class="ranking">
            <h2>Black Walk Team</h2>
            <strong class="colocacao">
              4º Lugar
            </strong>
          </article>
        </a>
        <a class="produtos-container col-md-3">
          <img src="./assets/images/painel5.jpeg" class="img-fluid" alt="Cropped rosa">
          <article class="ranking">
            <h2>Air 400</h2>
            <strong class="colocacao">
              5º Lugar
            </strong>
          </article>
        </a>
        <a class="produtos-container col-md-3">
          <img src="./assets/images/painel6.jpeg" class="img-fluid" alt="Camiseta manga comprida">
          <article class="ranking">
            <h2>MilitAir</h2>
            <strong class="colocacao">
              6º Lugar
            </strong>
          </article>
        </a>
        <a class="produtos-container col-md-3">
          <img src="./assets/images/painel7.jpeg" class="img-fluid" alt="Camiseta listrada">
          <article class="ranking">
            <h2>Alpha Air</h2>
            <strong class="colocacao">
              7º Lugar
            </strong>
          </article>
        </a>
        <a class="produtos-container col-md-3">
          <img src="./assets/images/painel8.jpeg" class="img-fluid" alt="Saia plisada">
          <article class="ranking">
            <h2>Team BSAT</h2>
            <strong class="colocacao">
              8º Lugar
            </strong>
          </article>
        </a>
        <a class="produtos-container col-md-3">
          <img src="./assets/images/painel9.jpeg" class="img-fluid" alt="Black River Airsoft">
          <article class="ranking">
            <h2>Nação Airsot</h2>
            <strong class="colocacao">
              9º Lugar
            </strong>
          </article>
        </a>
      </article>
      </a>
      </article>
  </main>

### Instruções de acesso 

1.	Abra um navegador de Internet e informe a URL https://vigilant-curran-675f62.netlify.app/ 
2.	No corpo do site ao clicar no botão “Veja mais”, onde o usuário é redirecionado para a tela de “Ranking nacional por equipes”, onde ele terá acesso as colações das demais equipes cadastradas.



