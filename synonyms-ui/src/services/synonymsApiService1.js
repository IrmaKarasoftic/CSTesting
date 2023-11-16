import axios from "axios";
const API_URL = `${process.env.REACT_APP_API_URL}/Synonyms`;

export const getAllWords = async () => {
  return axios.get(`${API_URL}`).then((res) => {
    if (res.data.isValid) {
      const words = res.data.data;
      return words;
    } else {
      alert("Something went wrong with fetching words");
    }
  });
};

export const getWordSynonyms = async (word) => {
  return axios.get(`${API_URL}/search?word=${word}`).then((res) => {
    if (res.data.isValid) {
      const words = res.data.data;
      return words;
    } else {
      alert("Something went wrong with fetching words");
    }
  });
};

export const addSynonym = async (word, synonymList) => {
  return axios
    .post(`${API_URL}`, {
      WordString: word,
      Synonyms: synonymList,
    })
    .then((res) => {
      if (res.data.isValid) {
        return res.data.isValid;
      } else {
        alert("Something went wrong with fetching words");
      }
    });
};
