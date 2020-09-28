<template>
     <div class="row mt-5" v-if="player">

    <h1>Profile Page </h1>
        <h2>Username: {{player.userName}}</h2>
        <h3>email: {{player.email}}</h3>
        <h4>DateJoined: {{player.dateJoined}}</h4>
    </div>
</template>

<script>
export default {
    props:['username'],
    computed:{
        player(){
            return this.$store.state.player;
        }
    },
    mounted(){
        this.$store.dispatch('getPlayer',this.username);
    }
    
}
</script>