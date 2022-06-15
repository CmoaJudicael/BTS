
	try
{
    //tableau de donnée des liens des pictos
var url_logo = 
{
    'fromage':'https://lesbouchersberrichons.fr/wp-content/uploads/2022/03/Fromage.webp',
    'epicerie':'https://lesbouchersberrichons.fr/wp-content/uploads/2022/03/picto_Epicerie.webp',
    'volaille':'https://lesbouchersberrichons.fr/wp-content/uploads/2022/03/picto_Poulet.webp',
    'oeufs_graines':'https://lesbouchersberrichons.fr/wp-content/uploads/2022/03/picto_Grainesoeuf.webp',
    'boeuf':'https://lesbouchersberrichons.fr/wp-content/uploads/2022/03/picto_Boeuf.webp',
    'veau':'https://lesbouchersberrichons.fr/wp-content/uploads/2022/03/picto_Veau.webp',
    'porc':'https://lesbouchersberrichons.fr/wp-content/uploads/2022/03/picto_Porc.webp',
    'vins':'https://lesbouchersberrichons.fr/wp-content/uploads/2022/03/picto_Vin.webp'
}
    

//Data
var logo_filtre = 
[
    'boeuf','volaille','porc','epicerie','fromage','vins','oeufs_graines'
]

//Donnée sur les pictos
var infoLogo = 
[
    {'top':'30','left':'21.368', 'position':'map','picto':'volaille', 'title':'Société Guillet ','sub_title':'Volaille fermière du Maine et Loire'},//0
    
    {'top':'25.46','left':'48.15', 'position':'map','picto':'epicerie', 'title':'Chips Bielsa','sub_title':'28150 Boisville La Saint Pere'},//1
    
    {'top':'53.75','left':'62.04', 'position':'map','picto':'epicerie', 'title':'Pâte François','sub_title':'PÂTES BRISEE ET FEUILLETEE'},//2
    
    {'top':'0','left':'36.145', 'position':'loupe','picto':'epicerie', 'title':'Le Rucher des Brosses','sub_title':'1 Chemin Des Brousses, Les Brosses, 18110 Allogny'},//3
    
    {'top':'30.12','left':'33.133', 'position':'loupe','picto':'epicerie', 'title':'Pâtes Fabre','sub_title':'Rte de Villeneuve, 18570 La Chapelle-Saint-Ursin'},//4
    
    {'top':'36.145','left':'54.217', 'position':'loupe','picto':'epicerie', 'title':'Farine d’Oudon, Dun sur Auron','sub_title':'Oudon, 18130 Vornay'},//5
    
    {'top':'36.775','left':'33.133', 'position':'loupe','picto':'epicerie', 'title':'Lentilles vertes du Berry','sub_title':'1 Rue de Bois Griffon, 18350 Cornusse'},//6
    
    {'top':'33.133','left':'0', 'position':'loupe','picto':'epicerie', 'title':'Huilerie merolles','sub_title':'Le Dom. de Mérolles, 36260 Paudy'},//7
    
    {'top':'63.65','left':'27.78', 'position':'map','picto':'epicerie', 'title':'Unité de Production Alimentaire du Loudunais','sub_title':'12 Rue des Forges, 86200 Loudun'},//8
    
    {'top':'3.012','left':'30.1205', 'position':'loupe','picto':'fromage', 'title':'La Ferme de Villemenard','sub_title':'Villemenard, 18500 Vignoux-sur-Barangeon'},//9
    
    {'top':'6.024','left':'24.096', 'position':'loupe','picto':'fromage', 'title':'Ferme Billon Sabatier','sub_title':'229 Sardonnet, 18500 Allouis'},//10
    
    {'top':'57.229','left':'45.1807', 'position':'loupe','picto':'fromage', 'title':'Le brebis du Berry','sub_title':'Les Bruyères, 18360 Saulzais-le-Potier'},//11
    
    {'top':'36.145','left':'27.108', 'position':'loupe','picto':'oeufs_graines', 'title':'Le Petit Châtelier','sub_title':'Le Châtelier, 18400 Saint-Florent-sur-Cher'},//12
    
    {'top':'0','left':'72.12', 'position':'loupe','picto':'oeufs_graines', 'title':'Cocoripop','sub_title':'La Villeneuve, 18300 Feux'},//13
    
    {'top':'27.108','left':'78.313', 'position':'loupe','picto':'boeuf', 'title':'Riotte Roland et Nicolas','sub_title':'Bessy, 18600 Sancoins'},//14
    
    {'top':'54.217','left':'3.012', 'position':'loupe','picto':'boeuf', 'title':'Piot Hugues','sub_title':'36400 Saint-Chartier'},//15
    
    {'top':'78.313','left':'60.241', 'position':'loupe','picto':'boeuf', 'title':'Laboisse Yvon et Benoit','sub_title':'Lindron, 03430 Sauvagny'},//16
    
    {'top':'18.072','left':'9.036', 'position':'loupe','picto':'boeuf', 'title':'Pied Chétif','sub_title':'Pied Chétif, 18120 Massay'},//17
    
    {'top':'48.193','left':'48.193', 'position':'loupe','picto':'veau', 'title':'Allouetteau Monique et Nicolas','sub_title':'Le Breuil, 18210 Coust'},//18
    
    {'top':'77.8','left':'72.22', 'position':'map','picto':'porc', 'title':'Hassenforder et Fils SA','sub_title':'Le Beau Rosier, 03000 Toulon-sur-Allier'},//19
    
    {'top':'25.301','left':'4.217', 'position':'loupe','picto':'vins', 'title':'Domaine Charpentier Reuilly et Quincy','sub_title':'Le Bourdonnat, 36260 Reuilly'},//20
    
    {'top':'12.651','left':'12.88', 'position':'loupe','picto':'vins', 'title':'Chateaumeillant : Domaine Rouze','sub_title':'2 Ter Chem. des Vignes, 18120 Quincy'},//21
    
    {'top':'12.048','left':'30.1204', 'position':'loupe','picto':'vins', 'title':'Brasserie de Tonton Fernand','sub_title':'24 Rte du Paradis, 18500 Mehun-sur-Yèvre'},//22
    
    {'top':'59.406','left':'64.815', 'position':'map','picto':'vins', 'title':'Sancerre : Domaine Delaporte','sub_title':'Rle de Chavignol, 18300 Sancerre'},//23
    
    {'top':'57.99','left':'66.667', 'position':'map','picto':'vins', 'title':'Coteaux du Giennois : Domaine Villargeau','sub_title':'3 voie romaine, Villargeau, 58200 Pougny'},//24
    
    {'top':'1.2048','left':'48.1928', 'position':'loupe','picto':'vins', 'title':'Domaine Fraiseau Leclerc','sub_title':'3 Rue du Chat, 18510 Menetou-Salon'},//25
    
    {'top':'62.528','left':'48.148', 'position':'map','picto':'vins', 'title':'Valencay : Domaine Morand','sub_title':'65 Rue Gd Rue Champcol, 41130 Selles-sur-Cher'},//26
]
//déclaration des attributs
var loupe = document.getElementById('loupe');
var map = document.getElementById('map');
var map_ = document.getElementById('map_');
var support_loupe = document.getElementById("support_loupe");  
var imgBg = document.getElementById('img-back');
var logo = document.getElementsByClassName('logo');
var logoFiltre = document.getElementsByClassName('logo-filtre');
var filtre = document.getElementById('filtre');


//fonction element interactif
    function info_hide(x)
    {
        document.getElementById('bulle_info').style.visibility = 'hidden';
    }
    function info_show(x)
    {
        document.getElementById('bulle_info').style.visibility = 'visible';
        var index = this.getAttribute('data-index');
        let bu_cat = document.getElementById('bulle_categorie');
		bu_cat.textContent = infoLogo[index]['picto'].toUpperCase();
		bu_cat.style.fontSize = '1.2em';
        let bu_tit = document.getElementById('bulle_title');
		bu_tit.textContent = infoLogo[index]['title'];
		bu_tit.style.fontSize = '1.5em';
		let bu_sub = document.getElementById('bulle_subtitle');
		bu_sub.textContent = infoLogo[index]['sub_title'];
		bu_sub.style.fontSize = '1.5em';
    }    
	
    function linkRef()
    {        
        var index = this.getAttribute('data-index');
        const str = "#fournisseur_"+index;
        location.href = str;
    }
    function actualisation()
    {
        var filtres = document.getElementsByClassName('filtres');
        for (let index = 0; index < filtres.length; index++) 
        {
            const element = filtres[index];
            var name = element.getAttribute('name');
            var imgLogo = document.getElementsByClassName(name);
        
        
            if(element.checked)
            {
                for (let index = 0; index < imgLogo.length; index++) 
                {
                    imgLogo[index].style.visibility= 'visible';
                }
            }
            else
            {
                for (let index = 0; index < imgLogo.length; index++) 
                {
                    imgLogo[index].style.visibility= 'hidden';
                }
            }
        }
    }

//initialisation picto
for (let index = 0; index < logoFiltre.length; index++) 
{
    const element = logoFiltre[index];
    let name = logo_filtre[index];
    element.src = url_logo[name];
}

document.getElementById('support_loupe').classList.add('transition');
function placeElement()
{
for (let index = 0; index < infoLogo.length; index++) 
{
    // crée un nouvel élément div
    var newDiv = document.createElement("div");
    const divcls = "pos-absolute "+infoLogo[index]['picto']+" logo";
    const ref = '#fournisseur_'+index;
    
    // crée un nouvel élément a
    var newA = document.createElement("a");
    newA.id = "link"+index;
    newA.href = ref;


    newDiv.classList.add("pos-absolute");
    newDiv.classList.add(infoLogo[index]['picto']);
    newDiv.classList.add("logo");
    newDiv.setAttribute('data-index', index);
    newDiv.setAttribute('onmouseover', "info_show(this)");
    newDiv.addEventListener("mouseover", info_show);
    newDiv.addEventListener("mouseout", info_hide);
    newDiv.id = index;
    // crée un nouvel élément img
    var newImg = document.createElement("img");
    const imgcls = "img_logo transition";
    const alt_txt = 'logo-'+infoLogo[index]['picto'];
    newImg.classList.add("img_logo");
    newImg.classList.add("transition");
    newImg.alt = alt_txt;
    let name = infoLogo[index]['picto'];
    newImg.src = url_logo[name];

    //ajoute img à a
    newA.appendChild(newImg);
    //ajoute a à div
    newDiv.appendChild(newA);

    
    if(infoLogo[index]['position']=='loupe')
    {
        loupe.append(newDiv);
    }
    else
    {
        map.append(newDiv);
    }
}


var img_logo = document.getElementsByClassName("img_logo");


	
//Sizing
function SizingElement()
{
	
	map.style.width = '100%';
	map.style.height = imgBg.offsetHeight+'px';
	
	support_loupe.style.width = ((map.offsetWidth*17.5847)/100)+'px';
	support_loupe.style.height = ((map.offsetWidth*17.5847)/100)+'px';
	support_loupe.style.marginTop = -(support_loupe.offsetHeight/2)+'px';
	support_loupe.style.marginLeft = -(support_loupe.offsetHeight/2)+'px';
	
    support_loupe.style.left = '60%';
    support_loupe.style.top = '75%';
	setTimeout(bg_loupe, 200);
	
	
	
    filtre.style.bottom = (filtre.offsetHeight+30)+'px';
    filtre.style.left = ((map.offsetWidth*1.09)/100)+'px';
    
    for (let index = 0; index < logo.length; index++)
    {
        const element = logo[index];
        let id_element = element.id;
        let name = infoLogo[id_element]['position'];
		
		
        element.style.top = ((document.getElementById(name).offsetHeight*infoLogo[id_element]['top'])/100)+'px';
        element.style.left = ((document.getElementById(name).offsetWidth*infoLogo[id_element]['left'])/100)+'px';
    }   
}
function bg_loupe()
	{
		loupe.style.backgroundSize = imgBg.offsetWidth+'px '+imgBg.offsetHeight+'px';
        loupe.style.backgroundPosition = (-support_loupe.offsetLeft)+"px "+(-support_loupe.offsetTop)+"px";
	}

SizingElement();

window.onresize = SizingElement;
}
window.onload = placeElement;
}
catch (error) 
{
    
}
