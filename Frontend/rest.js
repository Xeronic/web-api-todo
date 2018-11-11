export const api = {};

api.get = url => {
  return fetch(url);
};

api.post = (url, body) => {
  return fetch(url, {
    method: "post",
    headers: {
      "Content-Type": "Application/Json"
    },
    body: JSON.stringify(body)
  });
};

api.put = (url, body) => {
  return fetch(url, {
    method: "put",
    headers: {
      "Content-Type": "Application/Json"
    },
    body: JSON.stringify(body)
  });
};
