drop schema if exists prjSerie;
create schema prjSerie;
use prjserie;

create table categoria(
	cd_categoria int,
	nm_categoria varchar(100),
	constraint pk_categoria primary key (cd_categoria)
);

create table serie(
	cd_serie int,
	nm_serie varchar(200),
	nm_original varchar(200),
	aa_ano_lancamento int,
	nm_link_img text,
	ds_sinopse_serie text,
	constraint pk_serie primary key (cd_serie)
);

create table categoria_serie(
	cd_serie int,
	cd_categoria int,
	constraint pk_categoria_serie primary key (cd_serie, cd_categoria),
	constraint fk_categoria_serie_categoria foreign key (cd_categoria) 
		references categoria (cd_categoria),
	constraint fk_categoria_serie_serie foreign key (cd_serie) 
		references serie (cd_serie)
);

create table episodio(
	cd_serie int,
	cd_temporada int,
	cd_episodio int,
	nm_episodio varchar(150),
	nm_original varchar(150),
	dt_lancamento date,
	qt_duracao int,
	ds_sinopse_episodio text,
	ds_observacao text,
	constraint pk_episodio primary key (cd_episodio, cd_serie, cd_temporada),
	constraint fk_episodio_serie foreign key (cd_serie)
		references serie (cd_serie)
);

insert into categoria values (1, ' Ação');
insert into categoria values (2, ' Drama');
insert into categoria values (3, ' Ficção Científica');
insert into categoria values (4, ' Aventura');
insert into categoria values (5, ' Mistério');
insert into categoria values (6, ' Comédia');
insert into categoria values (7, ' Sitcom');
insert into categoria values (8, ' Fantasia');
insert into categoria values (9, ' Western Espacial');
insert into categoria values (10, 'sem Categoria ainda!');

insert into serie values (1, 'Flash', 'The Flash', 2014, 'TheFlash.jpg','O investigador forense Barry Allen (Grant Gustin) sofre um acidente em seu laboratório: ele leva um banho de produtos químicos e, em seguida, é atingido por um raio. A partir disso, ele se torna capaz de canalizar os poderes do "Campo de Velocidade" e de se locomover com uma rapidez sobre-humana. De máscara e uniforme vermelhos, Barry assume a identidade do super-herói Flash e começa a usar suas habilidades para patrulhar Central City, contando com a ajuda dos cientistas da S.T.A.R. Labs. Ao mesmo tempo que detém vilões, ele procura descobrir quem está por trás do assassino de sua mãe.');
insert into serie values (2, 'Arqueiro', 'Arrow', 2012,'Arrow.jpg','Playboy, milionário e mulherengo, Oliver Queen (Stephen Amell) está presumivelmente morto há 5 anos, quando um acidente de iate causou o desaparecimento dele, de seu pai, Robert (Jamey Sheridan), e Sara Lance, irmã de sua então namorada Laurel (Katie Cassidy). Mas Ollie sobreviveu e, preso em uma ilha, ele aprendeu a lutar por sua vida. De volta à civilização em Starling City, ele é um homem mudado e está decidido a honrar a memória do pai e livrar a cidade da corrupção. Disfarçado, ele usa as habilidades que aprendeu durante seu tempo de reclusão para isso, e ao mesmo tempo precisa esconder sua nova identidade da mãe, Moira (Susanna Thompson), da irmã, Thea (Willa Holland) e dos amigos.');
insert into serie values (3, 'Lendas do Amanhã da DC', "DC's Lengends of Tomorrow", 2016, 'Legends_of_Tomorrow.png','Quando heróis sozinhos não são o suficiente... o mundo precisa de lendas. Já tendo visto o futuro, um deles irá desesperadamente tentar impedi-lo de acontecer. Rip Hunter (Arthur Darvill), o viajante do tempo, recebe a tarefa de reunir um disforme grupo de heróis e vilões para confrontar uma ameaça difícil de parar; uma que não ameaça somente a integridade do planeta, mas do próprio tempo como uma entidade. Será que este improvável time é capaz de combater uma ameaça imortal, diferente de tudo que eles conhecem?');
insert into serie values (4, 'Wanda e Visão', 'WandaVision', 2021,'WandaVision.png','Após os eventos de "Vingadores: Endgame" (2019), Wanda Maximoff-Feiticeira Escarlate (Elizabeth Olsen) e Visão (Paul Bettany) se esforçam para levar uma vida normal no subúrbio e esconder seus poderes. Mas a dupla de super-heróis logo começa a suspeitar que nem tudo está tão certo assim. Eles se encontram, na verdade, dentro de uma constante sitcom, que vai desde a década de 50 até os dias de hoje. Conforme o tempo passa, Wanda e Visão perdem o controle da situação, sem saber mais o que é real e o que é ficção. Eles ficam presos em um eterno vai e vem: da Era de Ouro da TV nos EUA, com imagens em preto e branco, ao presente - e vice-versa.');
insert into serie values (5, 'Falcão e o Soldado Invernal', 'The Falcon and The Winter Soldier', 2021, 'FalcaoSoldado.jpg','Na série do Disney+ Falcão e o Soldado Invernal, após receber o manto do Capitão América em Vingadores: Ultimato, Sam Wilson-Falcão (Anthony Mackie) luta para assumir o posto do herói. Ele se junta, então, a Bucky Barnes-Soldado Invernal (Sebastian Stan), embarcando em uma aventura mundial que vai colocar à prova as habilidades dos dois. Entre discussões e entendimentos, acompanhamos uma jornada no desenvolvimento da amizade entre ambos, ao mesmo tentam em que tentam deixar para trás os problemas do passado. Enquanto o Falcão sente a responsabilidade do escudo de Steve Rogers, Bucky tenta lidar com a própria culpa por suas ações enquanto estava sob comando da Hydra.');
insert into serie values (6, 'Inumanos', "Marvel's Inhumans", 2017, 'Inhumans.jpg','Uma voz que pode destruir cidades, cabelos que são mortais e pés que causam terremotos. Esses são alguns dos poderes dos Inumanos, um grupo de seres raros e poderosos, que apesar da ascendência de humanos comuns, foram modificados após sucessivos testes realizados por uma raça de alienígenas conhecida como Kree. Organizados por um sistema de castas, eles são liderados pela Família Real, que vai fazer de tudo para manter a ordem na sociedade.');
insert into serie values (7, 'O Mandaloriano', 'THe Mandalorian', 2019, 'Mandalorian.jpg','Em The Mandalorian, Din Djarin (Pedro Pascal) é um guerreiro solitário que trabalha como caçador de recompensa. Ele embarca numa jornada pelos territórios esquecidos da galáxia, logo após a queda do Império e antes da criação da temida Primeira Ordem.');

insert into categoria_serie values (1, 1);
insert into categoria_serie values (1, 2);
insert into categoria_serie values (1, 3);

insert into categoria_serie values (2, 1);
insert into categoria_serie values (2, 4);
insert into categoria_serie values (2, 5);

insert into categoria_serie values (3, 3);
insert into categoria_serie values (3, 4);
insert into categoria_serie values (3, 6);

insert into categoria_serie values (4, 1);
insert into categoria_serie values (4, 6);
insert into categoria_serie values (4, 7);

insert into categoria_serie values (5, 1);
insert into categoria_serie values (5, 4);
insert into categoria_serie values (5, 8);

insert into categoria_serie values (6, 1);
insert into categoria_serie values (6, 2);
insert into categoria_serie values (6, 3);

insert into categoria_serie values (7, 2);
insert into categoria_serie values (7, 3);
insert into categoria_serie values (7, 9);


insert into episodio values (1, 1, 1, 'Piloto', 'Pilot', '2014-10-07', 43, 'Após ser atingido por um raio durante a explosão de um acelerador de particulas e passar nove meses em coma, Barry Allen acorda e percebe que o acidente lhe deu supervelocidade. Enquanto tenta assimilar sua nova condição, ele precisa aprender a controlar seus poderes quando outro meta-humano ameaça Central City.', null);
insert into episodio values (1, 1, 2, 'O Homem Mais Rápido Vivo', 'Fastest Man Alive', '2014-10-14', 43, "Barry acompanha Iris em um evento, mas quando homens armados invadem o local, o herói percebe que ainda precisa lidar com as consequências de seus poderes. Mais tarde, a equipe do S.T.A.R Labs descobre que tudo foi obra de um meta-humano capaz de criar múltiplos de si mesmo, enquanto Iris fica cada vez mais intrigada pelo 'borrão'.", 'Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra.');
insert into episodio values (1, 1, 3, 'O Que Não Dá Para Ultrapassar', "Things You Can't Outrun", '2014-10-21', 43, 'Barry, Joe e a equipe de S.T.A.R Labs trabalham juntos para lidar com um meta-humano com poderes de gases tóxicos. Uma situação que leva Caitlin a relembrar a dolorosa perda de seu noivo, Ronnie.', null);
insert into episodio values (1, 1, 4, 'Trapaceando', 'Going Rogue', '2014-10-28', 43, 'Leonard Snart, um inteligente criminoso, rouba uma arma de gelo capaz de matar o Flash. Já Joe não aceita o relacionamento entre Iris e Eddie.', null);
insert into episodio values (1, 2, 1,'O Homem Que Salvou Central City', 'The Man Who Saved Central City', '2015-10-06', 43, 'Ainda atormentado pelas perdas após a abertura da singularidade, Barry decide trabalhar sozinho para proteger a cidade. Mas a chegada de um meta-humano o faz reavaliar seus planos, enquanto Cisco ajuda Joe em uma força-tarefa.', 'Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra.');
insert into episodio values (1, 2, 2,'Flash de Dois Mundos', 'Flash of Two Worlds', '2015-10-13', 43, 'Jay Garrick, um misterioso homem vindo da Terra-2, aparece na S.T.A.R Labs para alertar sobre a presença de um vilão chamado Zoom. Barry tem problemas para confiar nele, enquanto Joe precisa lidar com Patty, uma policial determinada a fazer de sua força-tarefa de meta-humanos.', null);
insert into episodio values (1, 2, 3,'Família de Trapaceiros', 'Family of Rogues', '2015-10-20', 43, 'Barry e a equipe do S.T.A.R Labs formam uma aliança com Lisa Snart ao saber que Capitão Frio desapareceu, mas logo descobrem que nem tudo é o que parece. Já Joe é obrigado a tomar uma difícil decisão.', null);
insert into episodio values (1, 3, 1,'Ponto de Ignição', 'Flashpoint', '2016-10-04', 43, 'Barry finalmente consegue ser um cara normal, ao lado dos seus pais e se aproximando cada vez mais de Iris West. Sua vida tranquila, no entanto, não dura muito tempo. O Flash Reverso avisa que haverá graves consequências caso seu inimigo não retorne à sua vida como o Flash.', null);
insert into episodio values (1, 3, 2,'Paradoxo', 'Paradox', '2016-10-11', 43, 'Barry descobre que o impacto do Flashpoint é muito maior do que ele pensara. Ele também conhece seu novo colega de trabalho, que parece não gostar muito dele.', 'Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra.');
insert into episodio values (1, 4, 1,'O Flash Renascido', 'The Flash Reborn', '2017-10-10', 43, 'Iris esteve auxiliando o Time Flash em Central City durante seis meses, mas se recusando a sofrer por Barry. Um Samurai voador com superpoderes aparece em Central City, ameaçando a cidade se o verdadeiro Flash não o enfrentar. Cisco revela que elaborou uma maneira de trazer Barry de volta sem desestabilizar a Força de Aceleração e rastreia Caitlin para conseguir sua ajuda.', null);
insert into episodio values (1, 5, 1,'Nora', 'Nora', '2018-10-09', 43, 'O Time Flash encontra a filha de Barry e Iris do futuro, Nora. Enquanto Iris expressa excitação, Barry está preocupado que ela poderia alterar a linha do tempo com base em seus próprios erros com a viagem no tempo.', null);
insert into episodio values (1, 6, 1,'Salto no Vazio', 'Into The Void', '2019-10-08', 43, 'Momentos depois de perder sua filha Nora West-Allen, Barry e Iris encontram sua mensagem destruída. Quatro meses depois, eles aparentemente chegaram a um acordo com o que aconteceu, mas os outros não estão convencidos.', null);
insert into episodio values (1, 7, 1,'Tudo Está Bem Quando Termina em Wells', "All's Well That Ends Wells", '2021-03-02', 43, 'Quando um experimento para salvar a velocidade de Barry sai pela culatra, Nash Wells procura uma maneira de salvar o Flash e surge com um plano perigoso. Enquanto isso, Iris faz uma descoberta surpreendente dentro do Mirrorverse e Cecile enfrenta Rosa Dillon.', null);

insert into episodio values (2, 1, 1,'Piloto', 'Pilot', '2012-10-10', 43, 'Após cinco anos em uma ilha deserva, Oliver retorna a Starling City para colocar em prática suas táticas de sobrevivência e honrar o último desejo de seu pai. Mas, antes, ele precisa organizar sua vida, quando descobre que sua ex-namorada o odeia, sua mãe se casou novamente e sua irmã mais nova está usando drogas.', null);
insert into episodio values (2, 1, 2,'Honra Teu Pai', 'Honor Thy Father', '2012-10-17', 43, 'Laurel tenta mover um processo contra MArtin Somers, traficante de drogas que está na lista de Oliver. Enquanto isso, ele tenta se reconectar com a família ao mesmo tempo que recusa os esforços da mãe de o colocar na presidência da Queen Consilidated.', null);
insert into episodio values (2, 1, 3,'Lone Gunmen', 'Pistoleiros Solitários', '2012-10-24', 43, 'Um master assassino chega à cidade e mata um dos empresários que estava na lista de Oliver. Enquanto o persegue, Oliver descobre que deve proteger seu padrasto. Thea e Moira começam a resolver suas diferenças, e Tommy conta para o amigo que ele e Laurel estiveram envolvidos durante a sua ausência.', null);
insert into episodio values (2, 1, 4,'Um Homem Inocente', 'An Innocent Man', '2012-10-31', 43, 'Quando Oliver descobre que um homem inocente foi acusado por alguém de sua lista, ele procura a ajuda de Laurel para conseguir uma confissão. Enquanto isso, Diggle considera a oferta de trabalho de Oliver, e Walter descobre que Moira fez uma retirada dos fundos da companhia, às escondidas.', 'Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra.');
insert into episodio values (2, 2, 1,'Cidade de Heróis', 'City of Heroes', '2013-10-09', 43, 'Um ano se passou desde a morte de Tommy e a destruição dos Glades, e Oliver está vivendo na ilha sozinho. Diggle e Felicity o convencem a voltar para Starling City, mas ele se recusa a vestir o capuz.', null);
insert into episodio values (2, 2, 2,'Identidade', 'Identity', '2013-10-16', 43, 'Criminosos estão roubando os medicamentos que eram para as vítimas da explosão nos Glades, e Oliver decide que o Capuz deve por um fim nos roubos. Porém, nem tudo sai como ele imaginava, qunado o político local Sebastian Blood o acusa de ser responsável pelos atos de sua família.', null);
insert into episodio values (2, 2, 3,'Bonecas Despedaçadas', 'Broken Dolls', '2013-10-23', 43, 'Quando um ameaçador criminoso do passado de Lance escapa da prisão, Felicity se oferece como ísca para que o Arrow possa capturá-lo... mas será que vai dar certo?.', 'Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra.');
insert into episodio values (2, 3, 1,'A Calmaria', 'The Calm', '2014-10-08', 43, 'Com os crimes em baixa, Oliver decide dar um tempo e convida Felicity para um jantar. Porém, eles são interrompidos por um novo traficante que assume o lugar do Conde Vertigo, e mira na morte do Vigilante.', null);
insert into episodio values (2, 3, 2,'Sara', 'Sara', '2014-10-15', 43, 'Oliver e sua equipe tentam encontrar o arqueiro que alvejou Sara, e descobrem um atirador que atende por Komodo, e tem conexões com a Liga dos Assassinos. Enquanto isso, Ray continua tentando contratar Felicity, e Roy pondera se deve ou não contar a Oliver sobre Thea.', 'Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra.');
insert into episodio values (2, 4, 1,'Arqueiro Verde', 'Green Arrow', '2015-10-07', 43, 'Um novo inimigo chega à cidade, forçando Oliver a retornar a Starling City e iniciar uma nova batalha.', null);
insert into episodio values (2, 5, 1,'Legado', 'Legacy', '2016-10-05', 43, 'Após a morte de Laurel e a saída de Diggle e Thea da equipe, Oliver segue protegendo os cidadãos de Star City.', null);
insert into episodio values (2, 6, 1,'Recaída', 'Fallout', '2017-10-12', 43, 'Em flashbacks, Slade vai para o barco da A.R.G.U.S. sozinho enquanto os outros se refugiam no avião. Samantha foge para procurar William, e Thea a segue. Os músculos direitos do peito de John são feridos ao tentar resgatar Felicity.', null);
insert into episodio values (2, 7, 1,'Detento 4587', 'Inmate 4587', '2018-10-15', 43, 'Lacus enim ut luctus mattis dictum auctor risus facilisis, dolor libero blandit hac aliquam ante quisque, varius id consequat ut curabitur interdum nisl.', null);
insert into episodio values (2, 8, 1,'Starling City', 'Starling City', '2019-10-15', 43, 'Mar Novu - O Monitor envia Oliver Queen para a Terra-2 para recuperar partículas da Estrela Anã, mas elas são roubadas por Tommy Merlyn da Terra, que está tentando usá-las para destruir as Glades com sua própria versão do "Empreendimento".', null);

insert into episodio values (3, 1, 1, 'Piloto, Parte 1', 'Pilot, Part 1', '2016-01-21', 43, 'No ano de 2166, Vandal Savage conseguiu conquistar todo o planeta. Em uma tentativa de salvar a humanidade, o viajante do tempo Rip Hunter viaja para o ano de 2016 para organizar um grupo de super heróis e supervilões para formar uma equipe de elite para parar Savage: Ray Palmer, Sara Lance, Jefferson "Jax" Jackson, Dr. Martin Stein, Mick Rory, Leonard Snart, Carter Hall, e Kendra Saunders.', null);
insert into episodio values (3, 1, 2, 'Piloto, Parte 2', 'Pilot, Part 2', '2016-01-28', 43, 'Após receber uma pista sobre o paradeiro de Vandal Savage, o time se infiltra em um acordo de munições tendo o professor Stein como líder. Cercados pelos criminosos mais durões do mundo, as coisas logo saem do controle, já que Savage percebe que eles não fazem parte dali.', null);
insert into episodio values (3, 1, 3, 'Laços de Sangue', 'Blood Ties', '2016-02-04', 43, 'Rip decide enfraquecer Vandal Savage indo atrás de seus bens financeiros. Rip e Sara se infiltram no banco de Savage, mas são descobertos pelos homens do vilão. Enquanto isso, Snart e Rory convencem Jax a levar a nave de volta a Central City para que eles possam roubar uma valiosa esmeralda.', null);
insert into episodio values (3, 1, 4, 'Cavaleiros Brancos', 'White Knights', '2016-02-07', 43, 'Vandal Savage recua para a Cortina de Ferro no começo dos anos 80 e, como consequência, uma série de cientistas nucleares começam a desaparecer misteriosamente. O time segue o rastro de Vandal até o coração da União Soviética em uma tentativa de encontrar próximo alvo do vilão.', ' Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra. ');
insert into episodio values (3, 2, 1,'Fora do Tempo', 'Out of Time', '2016-10-13', 43, 'Em 2016, o historiador Nate Heywood pede ajuda ao prefeito de Star City, Oliver Queen, para localizar a nave do tempo afundada e encontram apenas Mick a bordo, em estase. Depois de ser acordado, Mick diz a eles o que aconteceu.', null);
insert into episodio values (3, 2, 2,'A Sociedade de Justiça da América', 'The Justice Society of America', '2016-10-20', 43, '', null);
insert into episodio values (3, 2, 3,'Shogun', 'Shogun', '2016-10-27', 43, ' Amaya se infiltra na nave e ataca Mick, acreditando que ele é o responsável pela morte de Rex. Nate a impede usando sua habilidade meta-humana recém-desenvolvida, conseguindo se transformar em aço. Sara convence Amaya de que um viajante do tempo trapaceiro foi quem matou Rex.', ' Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra. ');
insert into episodio values (3, 3, 1,'Aruba-Con', 'Aruba-Con', '2017-10-10', 43, 'Em Los Angeles, agora alterada, as Lendas encontram Rip, que revela que criou a "Agência do Tempo" para substituir o Conselho. Os agentes da Agência consertam os "anacronismos", e Rip separa as Lendas. Seis meses depois, as Lendas vivem vidas normais, nostálgicas em relação às suas aventuras anteriores.', null);
insert into episodio values (3, 3, 2,'O Show de Aberrações', 'Freakshow', '2017-10-17', 43, 'Seis meses atrás, Amaya descobriu sobre o vigilantismo de Mari e, de repente, abandonou Nate. No presente, as Lendas se dirigem a um pequeno anacronismo em Wisconsin, no ano de 1870, onde eles interrompem uma apresentação de circo de P.T. Barnum, que capturou um tigre dentes-de-sabre extinto.', ' Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra. ');
insert into episodio values (3, 4, 1,'O Virgem Gary', 'The Virgin Gary', '2018-10-22', 43, 'As Lendas e a Agência do Tempo comemoram um trabalho bem feito, enquanto Zari castiga Ray por permitir que Nora Darhk escapasse. Ava e Sara reacendem seu relacionamento. Constantine tenta avisar Sara sobre a escuridão chegando, mas Sara o dispensa.', null);
insert into episodio values (3, 5, 1,'Conheçam as Lendas', 'Meet the Legends', '2020-01-21', 43, 'Após os eventos de Hey World e a derrota de Neron, as Lendas se tornaram heróis públicos. Com a Agência do Tempo desmontado, Ava Sharpe se junta aos Legends e permite que uma equipe de documentários os filme para que possam levantar fundos.', null);
insert into episodio values (3, 6, 1,'Ground Control to Sara Lance', 'Ground Control to Sara Lance', '2021-05-02', 43, 'Depois de uma noite de festa em Londres em 1977 após a derrota de Lachesis, Ava Sharpe percebe que Sara Lance está desaparecida e aprende com David Bowie que ela ia propor, mas foi abduzida por alienígenas.', null);

insert into episodio values (4, 1, 1,'Gravado Ao Vivo Com Plateia', 'Filmed Before a Live Studio Audience', '2021-01-15', 43, 'Durante a década de 1950, os recém-casados Wanda e Visão mudam-se para a cidade de Westview. Eles tentam se misturar, apesar de Visão ser um andróide e Wanda ter habilidades telecinéticas.', null);
insert into episodio values (4, 1, 2,'Não Mude de Canal', "Don't Touch That Dial", '2021-01-15', 43, 'Durante a década de 1960, Wanda e Visão começam a ouvir ruídos estranhos fora de sua casa. No dia seguinte, eles preparam números de mágica para um show de talentos do bairro.', null);
insert into episodio values (4, 1, 3,'Agora em Cores', 'Now in Color', '2021-01-22', 43, 'Durante a década de 1970, o Dr. Nielson verifica a gravidez de Wanda, diz que ela está com quatro meses e que está tudo bem, antes de partir para as férias planejadas com sua esposa.', 'Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra.');

insert into episodio values (5, 1, 1,'Nova Ordem Mundial', 'New World Order', '2021-03-19', 43, 'Depois que metade de toda a vida voltou do Blip[b], cinco anos após seu desaparecimento, Sam Wilson / Falcão trabalha com a Força Aérea dos EUA na Tunísia para rastrear um avião sequestrado por Georges Batroc e membros do grupo terrorista LAF.', null);
insert into episodio values (5, 1, 2,'O Herói Americano', 'The Star-Spangled Man', '2021-03-26', 43, 'John Walker faz uma aparição no programa Good Morning America como Capitão América e revela seu desejo de viver à altura o manto de Steve Rogers.', null);
insert into episodio values (5, 1, 3,'Mercador do Poder', 'Power Broker', '2021-04-02', 43, 'Sem o conhecimento de Sam, Bucky orquestra um motim na prisão para ajudar Zemo a escapar, concordando em ajudar a deter os Apátridas. Eles viajam para Madripoor, uma cidade-estado santuário do crime, e se encontram com Selby, uma criminosa de alto escalão.', 'Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra.');

insert into episodio values (6, 1, 1,'Os Inumanos Chegam Na Terra', 'Behold... The Inhumans', '2017-09-29', 43, 'Rixa entre irmãos para salvar o futuro de seu povo', null);
insert into episodio values (6, 1, 2,'Aqueles Que Irão Nos Destruir', 'Those Who Would Destroy Us', '2017-09-29', 43, 'A Família Real foge para o Havaí depois de um golpe', null);
insert into episodio values (6, 1, 3,'Dividir e Conquistar', 'Divide and Conquer', '2017-10-06', 43, 'Os Inumanos precisam descobrir em quem podem confiar na Terra', 'Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra.');

insert into episodio values (7, 1, 1,'Capítulo 1: O Mandaloriano', 'Chapter 1: The Mandalorian', '2019-11-12', 43, 'Cinco anos após a queda do Império Galáctico, um caçador de recompensas Mandaloriano entrega sua mais recente recompensa para Greef Karga.', null);
insert into episodio values (7, 1, 2,'Capítulo 2: A Criança', 'Chapter 2: The Child', '2019-11-15', 43, 'Ao retornar à sua nave com a Criança, o Mandaloriano luta e mata um grupo de caçadores de recompensa rivais que o emboscam. Perto de sua nave, ele descobre que ela foi saqueada por Jawas em busca de peças e decide confrontá-los violentamente.', null);
insert into episodio values (7, 1, 3,'Capítulo 3: O Pecado', 'Chapter 3: The Sin', '2019-11-22', 43, 'O Mandaloriano entrega a Criança ao Cliente em Nevarro e coleta a recompensa de vinte barras de aço de Beskar. De maneira incomum, o Mandaloriano pergunta sobre os planos do Cliente para a Criança, mas ele diz que isso não é da sua conta.', 'Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra.');

insert into episodio values (7, 2, 1,'Capítulo 9: O Xerife', 'Chapter 9: The Marshal', '2020-10-30', 43, 'O Mandaloriano foi encarregado de devolver sua carga, uma criança, ao seu povo, os Jedi. Ele começa a procurar outros Mandalorianos que ele acredita que podem ajudá-lo a encontrar os Jedi, e é direcionado a um suposto Mandaloriano operando na cidade de Mos Pelgo, em Tatooine.', null);
insert into episodio values (7, 2, 2,'Capítulo 10: A Passageira', 'Chapter 10: The Passenger', '2020-11-06', 43, 'O Mandaloriano concorda em levar uma Mulher Sapo e seus ovos de Tatooine para a lua do estuário Trask, onde seu marido fertilizará os ovos, em troca de informações sobre outros Mandalorianos. Devido à fragilidade dos ovos, eles devem viajar em velocidades lentas "sub-leves".', 'Sed a quam eu lorem pretium fringilla. Vestibulum facilisis neque volutpat faucibus viverra.');
