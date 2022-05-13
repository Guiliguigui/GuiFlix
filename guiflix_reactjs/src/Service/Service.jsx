import axios from "axios";

const url = "https://localhost:44330/api/"

//users
export const get = path => {
    return axios.get(url + path);
}

export const post = (path, data) => {
    return axios.post(url + path, data);
}

export const supprime = (path, id) => {
    console.log(id)
    console.log(path)
    return axios.delete(url + path + id);
}