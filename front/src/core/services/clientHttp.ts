import axios from 'axios';

const clientHttp = axios.create({
  baseURL: import.meta.env.VITE_API_URL || 'http://localhost:3000/',
});

clientHttp.interceptors.request.use((config) => {
  return config;
});

clientHttp.interceptors.response.use(
  (response) => response,
  (error) => {
    switch (error.response?.status) {
      case 403:
        console.error('Accès interdit');
        break;
      case 404:
        console.error('Ressource non trouvée');
        break;
      case 500:
        console.error('Erreur serveur');
        break;
      default:
        console.error('Erreur inconnue:', error);
        break;
    }

    return Promise.reject(error.response?.data || error.message);
  }
);

export default clientHttp;
