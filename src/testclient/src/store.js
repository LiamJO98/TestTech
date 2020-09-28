import Vue from 'vue';
import Vuex from 'vuex';
import axios from 'axios';
Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    players :[],
    player: null
  },
  mutations: {
    SET_PLAYERS  (state, players) {
      state.players = players;
      console.log(players + "omg boys");
    },
    SET_PLAYER (state,player){
      state.player = player;
      console.log(player + " player been set");
    }
  },
  actions: {
      getPlayers ({commit}) {
        axios.get("https://localhost:5001/api/players")
        .then(response => {
          console.log(response);
          commit('SET_PLAYERS',response.data);
        })        
      },
      getPlayer ({commit}, userName){
        axios.get("https://localhost:5001/api/players/"+ userName)
        .then(response => {
          console.log(response);
          commit('SET_PLAYER', response.data);
        })
      }
  },

});
