<template>
    <div>
         <h1>Players Page</h1>    
            <div v-for="(player,index) in players" :key="index">
                <router-link :to="{name:'userProfile',params: {username: player.userName, email:player.email,datejoined:player.dateJoined }}">{{player.userName}}</router-link>
                <p>{{player.email}}</p>
                <p>{{player.dateJoined}}</p>
            </div>
    </div>


</template>

<script>
export default {
    mounted(){
        this.$store.dispatch('getPlayers');
    },
    computed:{
        players(){
            return this.$store.state.players;
        }
    }
}
</script>


<style>

</style>