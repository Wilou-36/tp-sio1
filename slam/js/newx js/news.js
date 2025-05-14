class News {
    
    
    constructor(titre, desc){
        this.titre = titre;
        this.desc = desc;
        this.Rendu();
    }

    Rendu(){
        let actu = document.getElementById('actu');
        actu.innerHTML += this.Template();
        this.color();
        this.Action();
        this.Supprimer();
    }

    Template(){
        return `<div class="news"> <h4> ${this.titre}</h4>  <p> ${this.desc} </p>  <button> supprimer ${this.Supprimer}</div> `;
    }

    color(){
        document.getElementById("actu").style.color = "green";
    }

    Action(){
        document.getElementById("actu").addEventListener("click", function(){})
    }

    Supprimer(){
        document.getElementById("actu").removeEventListener("actu",)
    }

}