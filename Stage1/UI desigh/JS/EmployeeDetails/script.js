class Employee 
{
    constructor(name,designation,year_of_experience){
        this.name = name;
        this.designation = designation;
        this.year_of_experience = year_of_experience;
}
}

function displayEmployee(name,designation,year_of_experience){
    
    var emp = createEmployee(name,designation,year_of_experience);
    if(validateObject(emp)){
        let date = new Date();
        let now = date.getFullYear() - year_of_experience - 2;
        
        var result = name+" is serving the position of "+designation+" since "+now;
        return result
    }
    else{
        return 'not valid';
    }
}
function createEmployee(name, designation, year_of_experience)
{
    let emp = new Employee(name,designation,year_of_experience);
   return emp;

}

function validateObject(employee)
{
    return employee instanceof Employee;
    
}