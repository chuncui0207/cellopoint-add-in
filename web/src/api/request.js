import axios from "axios";

const parseErrorResponse = error => {
  if (error.response.status === 400) {
    if (error.response && error.response.data) {
      return error.response.data.error_description || error.response.data.error;
    }
  } else if (error.response.status === 403) {
    if (error.response && error.response.data) {
      return error.response.data.error.message;
    }
  }

  return error.message;
};

const service = axios.create({
  timeout: 5000
});

service.interceptors.request.use(
  config => {
    return new Promise(function(resolve, reject) {
      Office.context.mailbox.getCallbackTokenAsync({ isRest: true }, function(result) {
        if (result.status === "succeeded") {
          config.headers["Authorization"] = "Bearer " + result.value;

          resolve(config);
        } else {
          reject(config);
        }
      });
    });
  },
  error => {
    console.log(error); // for debug
    return Promise.reject(error);
  }
);

service.interceptors.response.use(
  response => {
    return response;
  },
  error => {
    console.log("err" + error); // for debug
    Message({
      message: parseErrorResponse(error),
      type: "error",
      duration: 5 * 1000
    });
    return Promise.reject(error);
  }
);

export default service;
