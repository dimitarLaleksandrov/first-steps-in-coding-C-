import {get, post, put, del } from './api.js';

const endpoints = {
    'album': "/data/albums",
    'getAlbums': "/data/albums/:id",
    'albumForDelete': "/data/albums/:id"
};
export async function createAlbum(data) {
    return post(endpoints.album.data);
}
export async function getAll() {
    return get(endpoints.album);
}
export async function getAlbums() {
    return get(endpoints.getAlbums);
}
export async function deleteAlbum(id) {
    return del(endpoints.albumForDelete + id);
}