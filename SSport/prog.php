<?php 
class  Prog{
    public string $Nom;
    private $array $exercice;

    /**
     * Summary of _construct
     * @param string $Nom 
     */

    public function __construct(string $Nom){
        $this->Nom = $Nom;
        $this-> Exercice = []
    }

    function get_nom() {
        return $this->Nom;
    }

    public function ajouterexo( Exercice $exercice ){
        return this->Exercice = [];
    }

    public function get_exo(){
        return this->Exercice;
    }

    public function set_exo(){
        $this-> Exercice = []
    }


}



?>