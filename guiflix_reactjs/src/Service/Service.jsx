import axios from "axios";

const url = "https://localhost:3001/api/"

//users
export const get = (path, config) => {
    return axios.get(url + path, config);
}

export const post = (path, data, config) => {
    return axios.post(url + path, data, config);
}

export const supprime = (path, config) => {
    return axios.delete(url + path, config);
}