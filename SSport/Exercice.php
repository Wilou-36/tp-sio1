<?php 
/**
 * programme qui permet d'instancier un exo de sport
 */
class  Prog{
    public string $Nom;
    public int $Serie;
    public int $Repetition;
    public int $Poids;
    
    /**
     * Summary of _construct
     * @param string $Nom - Nom de l'exo
     * @param int $Serie - le nbr de série
     * @param int $Repetition - le nbr de repetition
     * @param int $poids - le poids en KG
     */
  

    public function __construct(string $Nom, int $Serie, int $Repetition, int $Poids){
        $this->Nom = $Nom;
        $this->Serie = $Serie;
        $this->Repetition = $Repetition;
        $this->Poids = $Poids;
    }

    public function get_nom() {
        return $this->Nom;
    }
    public function get_serie() {
        return $this->Serie;
    }
    public function get_repetition() {
        return $this->Repetition;
    }
    public function get_poids() {
        return $this->Poids;
    }


    public function set_nom($Nom){
        $this->Nom = $Nom;
    }
    public function set_serie($Serie){
        $this->Serie = $Serie;
    }
    public function set_repetition($Repetition){
        $this->Repetition = $Repetition;
    }
    public function set_poids($Poids){
        $this->Poids = $Poids;
    }


}



?>