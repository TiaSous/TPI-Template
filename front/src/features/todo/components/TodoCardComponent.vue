<script setup lang="ts">
defineProps<{
    title: string
}>();
</script>

<template>
    <div class="todo-card">
        <input class="checkbox-round" type="checkbox" name="isCompleted" id="">
        <p>{{ title }}</p>

    </div>
</template>

<style scoped>
.todo-card {
    display: flex;
    align-items: center;
    gap: 8px;
    padding: 8px;
}

.checkbox-round {
    width: 2em;
    height: 2em;
    background-color: rgba(255, 255, 255, 0);
    border-radius: 50%;
    vertical-align: middle;
    border: 1px solid #fafafa;
    appearance: none;
    -webkit-appearance: none;
    outline: none;
    cursor: pointer;
}

.checkbox-round:checked {
    background-color: var(--green-dark);
}
</style>
