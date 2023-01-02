class vehicle{
    static  id=0;
    constructor(vNo,type){
       
        this.id=++vehicle.id;
        this.vNo=vNo;
        this.type=type;
        this.date =new Date();
    }
    
}

class ToolManager{
    #vehicle=[]
    // #carData=[]
    // #truckData=[]
    // #busData=[]
    getVehicle=()=>this.#vehicle;
    addCar=(vNo)=>this. #vehicle.push(new vehicle(vNo,"CAR"));//{}
    addTruck=(vNo)=>this. #vehicle.push(new vehicle(vNo,"TRUCK"));
    addBus=(vNo)=>this. #vehicle.push(new vehicle(vNo,"BUS"));

    totalCar=()=>this.#vehicle.filter(e=>  e.type=="CAR").length;
    totalTruck =()=>this.#vehicle.filter(e=>  e.type=="TRUCK").length;
    totalBus =()=>this.#vehicle.filter(e=>  e.type=="BUS").length;
    totalCarC=()=>this.totalCar()*50;
    totalTruckC=()=>this.totalTruck()*200;
    totalBusC=()=>this.totalBus()*150;
}