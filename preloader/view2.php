<html>
<head>
<title>vie artificielle</title>
<style>

P{
	font-size:10pt;
	color:#000000;
}

P:first-letter {
	font-size:20pt;
	color:#7777FF;
}

.board{
	position: absolute;
	margin-left: 600px;
	margin-top: 5px;
	border-color:#0077FF;
	color:#000000;
}

.food{
	background-color: rgb(200, 250, 100);
}

.case{
	background-color: rgb(100, 150, 250);
}

.cellule{
	background-color: rgb(200, 0, 0);
}

.cellule_dead{
	background-color: rgb(0, 0, 0);
}
</style>
</head>
<body>
<div id="log" cols="50" rows="7" style="position:absolute;margin-top:5px;margin-left:5px;">
</div>
<input type="button" id="acte" value="stop" onclick="controle();"  style="position:absolute;margin-top:105px;margin-left:105px;"/>
<p style="position:absolute;margin-top:205px;margin-left:5px;width:550px;">Ceci est un jeu de la vie ! Le tableau est constitué de cases, ses dimentions sont de 15*15 cases, (ceci est définit en constantes, mais on peut le changer en modifiant les sources, seul deux lignes sont à changer...), chaque case peut contenir une cellule vivante ou morte, de la nouriture ou rien du tout... Les cellules se déplacent, elles ne peuvent pas marcher sur de la nouriture, ni sur une cellule morte, encore moins sur une autre cellule... Lorsqu'elles trouvent de la nouriture, elles commencent à manger, jusqu'a épuisement des stocks. Lorsqu'elles mangent, elles retrouvent de l'énergie, quand elles se déplacent, elles perdent beaucoups d'énergie, quand elles ne font rien, elles en perdent un peu. Lorsqu'elles n'ont plus d'énergie, elles meurent, lorsqu'elles en ont plus de 100, elles se divisent.</p>
<script type="text/javascript">

const taille_x=15;
const taille_y=15;
var nbr_cellules=5;
var tour=0, started=1;

cellules=new Array(nbr_cellules);			//le tableau qui contient les cellules
tab=new Array(taille_x);				// le tableau qui contient les obstacles
food=new Array(taille_x);				//le tableau qui contient l'emplacement de la nouriture

for (i=0;i<taille_x;i++){
	food[i]=new Array(taille_y);
	tab[i]=new Array(taille_y);
}
function afficher_case_details(vx,vy){
	var i;
	if (tab[vx][vy]){
		if (food[vx][vy]){
			alert("food : "+food[vx][vy]);
		}else{
			for (i=0;i<nbr_cellules;i++){
				if (cellules[i].pos_x==vx && cellules[i].pos_y==vy){
					alert(cellules[i].details());
				}
			}
		}
	}
}
function controle(){
	/*
	fonction qui permet de faire une pause

	
*/

	if (started==1){
		document.getElementById('acte').value="continue";
		started=0;
	}else{
		document.getElementById('acte').value="stop";
		started=1;
		startmove();
	}
}

function Adn(a,b,c,d,e){
	/*
	La class ADN

	
*/

	this.turn=new Array(4);
	this.want_to_turn=e;
	this.give_turn=Adn_turn;
	this.mute=Adn_muter;
	this.details=Adn_details;
	this.turn[0]=a;
	this.turn[1]=b;
	this.turn[2]=c;
	this.turn[3]=d;
	return(this);
}

function Adn_details(){
	str="";
	str+="0=>"+this.turn[0]+"\n";
	str+="1=>"+this.turn[1]+"\n";
	str+="2=>"+this.turn[2]+"\n";
	str+="3=>"+this.turn[3]+"\n";
	return str;
}

function Adn_muter(){
	/*
	Fonction qui fait muter l'ADN

	
*/

	var e=rnd(5);
	var f=rnd(2)-1;
	if (e<4)
		this.turn[e]+=f;
	else
		this.want_to_turn+=f;
}

function Adn_turn(a,b,c,d, direction){
	/*
	les déplacements de la cellules sont stoqués dans l'adn

	
*/

	var tabl=new Array(4);
	tabl[0]=a;
	tabl[1]=b;
	tabl[2]=c;
	tabl[3]=d;
	//alert(" a="+a+" b="+b+" c="+c+" d="+d);
	var chose=-1, e;
	if (a+b+c+d==1){
			if (a==1) chose=0;
			if (b==1) chose=1;
			if (c==1) chose=2;
			if (d==1) chose=3;
	}else if (a==1 || b==1 || c==1 || d==1){
		if (rnd(this.want_to_turn)!=1 && tabl[direction]==1){
			chose=direction;
		}else{
			while (1)
			{
				e=rnd(4);
				if ( tabl[e]==1 && rnd(this.turn[e])==1){ chose=e; break;}
			}
		}
	}
	return chose;
}

function Cellule(pos_x,pos_y, a, b, c, d){
	/*
	La class cellule

	
*/

	this.adn=new Adn(a, b, c, d);
	this.etat=1;
	this.food=50;
	this.pos_x=pos_x;
	this.pos_y=pos_y;
	this.direction=0;
	this.afficher=Cellule_afficher;
	this.bouger=Cellule_bouger;
	this.camoufler=Cellule_camoufler;
	this.details=Cellule_details;
	return(this);
}

function Cellule_details(){
	var str="";
	str=(this.etat==1)?"Cellule vivante\n":"Cellule morte\n";
	str+="food : "+this.food+"\n";
	str+=this.adn.details();
	return str;
}

function Cellule_afficher(){
	/*
	la fonction qui permet d'afficher une cellule

	
*/

	if (this.etat==1)
		document.getElementById('case_x_'+this.pos_x+'_y_'+this.pos_y).setAttribute("class","cellule");
	else
		document.getElementById('case_x_'+this.pos_x+'_y_'+this.pos_y).setAttribute("class","cellule_dead");
	tab[this.pos_x][this.pos_y]=1;
}

function Cellule_camoufler(){
	/*
	la fonction qui efface la cellule

	
*/

	document.getElementById('case_x_'+this.pos_x+'_y_'+this.pos_y).setAttribute("class","case");
	tab[this.pos_x][this.pos_y]=0;
}

function Cellule_bouger(){
	/*
	la fonction qui fait se déplacer la cellule

	
*/

	var retour=0;
	if (this.etat==1){
		var peut_bouger=new Array(4), i, have_move=1, manger=-1;
		if (this.pos_y!=0)
			if (food[this.pos_x][this.pos_y - 1]!=0)			manger=0;
		if (this.pos_x!=taille_x-1)
			if (food[this.pos_x + 1][this.pos_y]!=0)			manger=1;
		if (this.pos_y!=taille_y-1)
			if (food[this.pos_x][this.pos_y + 1]!=0)			manger=2;
		if (this.pos_x!=0)
			if (food[this.pos_x - 1][this.pos_y]!=0)			manger=3;
		
		if (manger==-1){
			peut_bouger[0]=0;
			peut_bouger[1]=0;
			peut_bouger[2]=0;
			peut_bouger[3]=0;
			if (this.pos_y!=0)
				if (tab[this.pos_x][this.pos_y - 1]==0)			peut_bouger[0]=1;
			if (this.pos_x!=taille_x-1)
				if (tab[this.pos_x + 1][this.pos_y]==0)		peut_bouger[1]=1;
			if (this.pos_y!=taille_y-1)
				if (tab[this.pos_x][this.pos_y + 1]==0)		peut_bouger[2]=1;
			if (this.pos_x!=0)
				if (tab[this.pos_x - 1][this.pos_y]==0)			peut_bouger[3]=1;

			i=this.adn.give_turn(peut_bouger[0],peut_bouger[1],peut_bouger[2],peut_bouger[3], this.direction);

			switch (i){
				case 0 :
					this.pos_y--;
					break;
				case 1 :
					this.pos_x++;
					break;
				case 2 :
					this.pos_y++;
					break;
				case 3 :
					this.pos_x--;
					break;
				default :
					have_move=0;
					break;
			}
			if (i!=-1) this.direction=i;
			
			this.food-=have_move*2+1;

		}else{
			this.food+=20;
			switch (manger){
				case 0 :
					food[this.pos_x][this.pos_y - 1]--;
					if (food[this.pos_x][this.pos_y - 1]==0){
						document.getElementById('case_x_'+this.pos_x+'_y_'+(this.pos_y-1)).setAttribute("class","case");
						tab[this.pos_x][this.pos_y - 1]=0;
					}
					break;
				case 1 :
					food[this.pos_x+1][this.pos_y]--;
					if (food[this.pos_x+1][this.pos_y]==0){
						document.getElementById('case_x_'+(this.pos_x+1)+'_y_'+this.pos_y).setAttribute("class","case");
						tab[this.pos_x+1][this.pos_y]=0;
					}
					break;
				case 2 :
					food[this.pos_x][this.pos_y+1]--;
					if (food[this.pos_x][this.pos_y + 1]==0){
						document.getElementById('case_x_'+this.pos_x+'_y_'+(this.pos_y+1)).setAttribute("class","case");
						tab[this.pos_x][this.pos_y + 1]=0;
					}
					break;
				case 3 :
					food[this.pos_x-1][this.pos_y]--;
					if (food[this.pos_x-1][this.pos_y]==0){
						document.getElementById('case_x_'+(this.pos_x-1)+'_y_'+this.pos_y).setAttribute("class","case");
						tab[this.pos_x-1][this.pos_y]=0;
					}
					break;
			}
		}
		if (this.food<=0)		//si la cellule doit mourrir...
			this.etat=0;
		if (100<this.food){		//si la cellule doit se diviser
			this.food-=50;
			retour =1;
		}
	}
	return retour;
}

function startmove(){
	/*
	la fonction "main"

	
*/

	if (started==1){
		tour++;
		var a=0; log_="Il y a "+nbr_cellules+" cellules !<br />", en_vie=nbr_cellules, mortes=0;
		for (i=0;i<nbr_cellules;i++){
			cellules[i].camoufler();
			a=cellules[i].bouger();
			cellules[i].afficher();
			if (cellules[i].etat==0){
				en_vie--;
				mortes++;
			}
			if (a==1){		//fait se diviser la cellule
				cellules[nbr_cellules]=new Cellule(cellules[i].pos_x,cellules[i].pos_y, cellules[i].adn.turn[0], cellules[i].adn.turn[1], cellules[i].adn.turn[2], cellules[i].adn.turn[3], cellules[i].adn.want_to_turn);
				cellules[nbr_cellules].adn.mute();
				nbr_cellules++;
				log_+="La cellule "+i+"se divise !<br />";
			}
		}
		//affiche le log
		log_+="Nous sommes au tour "+tour+".<br />Il y a "+en_vie+"cellules en vie et "+mortes+" cellules mortes...";
		document.getElementById("log").innerHTML=log_;
		setTimeout('startmove();',1000);		//se rapelle
	}
}

function rnd(n){
/*
un nombre au hasard

*/

	return Math.floor(Math.random()* n);
}

/*
On affiche le plateau

*/

document.write('<table class="board">');
for (vy=0;vy<taille_y;vy++){
	document.write('<tr>');
	for (vx=0;vx<taille_x;vx++){
		tab[vx][vy]=0;
		if (rnd(10)==1){
			food[vx][vy]=10;
			tab[vx][vy]=1;
			classe="food";
		}else{
			 food[vx][vy]=0;
			 classe="case";
		}
		document.write('<td><input class="'+classe+'" id="case_x_'+vx+'_y_'+vy+'" type="text" size="1" onclick="afficher_case_details('+vx+','+vy+');" /></td>');
	}
	document.write('</tr>');
}
document.write('</table>');
/*
on affiche chaque cellule

*/

for (i=0;i<nbr_cellules;i++){
	tab[0][i]=1;					//dans tab, on dit si la case est OQP
	cellules[i]=new Cellule(0,i, rnd(10)+10, rnd(10)+10, rnd(10)+10, rnd(10)+10, rnd(10));
	cellules[i].afficher();
}

//commence les déplacements
startmove();

</script>
</body>
</html>