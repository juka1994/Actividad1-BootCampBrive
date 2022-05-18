const urlBase = "https://localhost:44338";

const MetodoGet = () =>{
    fetch(`${urlBase}/api/book/books`)
    .then(response => response.json())
    .then(data => console.log("Metodo Get api", data))
};

const MetodoGet2 = (id) => {
    
     fetch(`${urlBase}/api/book/${id}`)
    .then(response => response.json())
    .then(data => console.log("Metodo Get por id api", data))

};

const MetodoPost = () =>{
    const person = {
        id: 19,
        title: "Libro nuevo",
        editorial: "Editorial nuevo",
        pages: 130,
        createdDate: "2022-05-17"
    }

    fetch(`${urlBase}/api/book`,{
        method: 'POST',
        body: JSON.stringify(person),
        headers:{
            'Content-Type': 'application/json'
        }
    })
    .then(response => response.json())
    .then(data => console.log("Metodo POST api", data))
};

const MetodoPut = () =>{
    const book = {
        id: 3,
        title: "Libro editado",
        editorial: "Editorial nuevo",
        pages: 130,
        createdDate: "2022-05-17"
    }

    fetch(`${urlBase}/api/book`,{
        method: 'PUT',
        body: JSON.stringify(book),
        headers:{
            'Content-Type': 'application/json'
        }
    })
    .then(response => response.json())
    .then(data => console.log("Metodo PUT api", data))
};

const MetodoDelete = (id) =>{
    fetch(`${urlBase}/api/book`,{
        method: 'DELETE',
        body: JSON.stringify(id),
        headers:{
            'Content-Type': 'application/json'
        }
    })
    .then(response => response.json())
    .then(data => console.log("Metodo DELETE api", data))
}




MetodoGet2(6);
MetodoGet();
MetodoPost();
MetodoPut();
MetodoDelete(7);
