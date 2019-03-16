import http from "../utils/http";

const TaskService = {

  list() {
    return http.get("/api/task");
  },

  add(value) {
    return http.post("/api/task");
  }

};


export default TaskService;
