<script setup lang="ts">
import { onMounted } from 'vue';
import { useTodoStore } from '../stores/todoStore';
import ListTodoComponent from '../components/ListTodoComponent.vue';

const todoStore = useTodoStore();
onMounted(() => {
    todoStore.fetchTodos();
});
</script>

<template>
    <h1>Todo</h1>
    <ListTodoComponent :todos="todoStore.todos" :isLoading="todoStore.isLoading" />
</template>
