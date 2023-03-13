import 'firebase/database';

export default class FBRepository {
    constructor(collection, app){
        this.collection = collection;
        this.db = app.database();
    }

    async getAll(){
        let cRef = this.db.ref(this.collection);
        
        return cRef.once('value')
            .then(function(data){
                return Array.from(Object.entries(data.toJSON()))
                .map((e) => {
                    let todo = e[1];
                    todo.id = e[0];
                    
                    return todo;                        
                });
            });
    }

    async getById(id){
        let path = `${this.collection}/${id}`;
        let ref = this.db.ref(path);

        return ref.once('value')
            .then(function(data){
                return data.toJSON();
            });
    }

    async add(entity){
        return this.db.ref(this.collection)
            .push(entity)
            .then(function(data){
                return data.key;
            });; 
    }

    async update(entity, partial = false){
        if (!entity.id) {
            throw new Error('Entity must have identificator');
        }

        let path = `${this.collection}/${entity.id}`;
        let eRef = this.db.ref(path);

        if (partial) {
            eRef.update(entity.value);
        } else {
            eRef.set(entity.value);
        }

        return entity.key;
    }

    async delete(id){
        let path = `${this.collection}/${id}`;
        this.db.ref(path).remove();

        return id;
    }
}