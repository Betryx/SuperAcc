<script setup>

</script>

<template>
    <header class="navbar">
    <div class="navbar-container">
      <div class="logo">
        <img src="" alt="Furniro Logo" class="logo-img" />
        <span class="brand-name">Furniro</span>
      </div>
      <nav class="nav-links">
        <a href="#" class="nav-item">Home</a>
        <a href="#" class="nav-item">Shop</a>
        <a href="#" class="nav-item">About</a>
        <a href="#" class="nav-item">Contact</a>
      </nav>
      <div class="nav-icons">
        <img src="" alt="User" class="icon" />
        <img src="" alt="Search" class="icon" />
        <img src="" alt="Wishlist" class="icon" />
        <img src="" alt="Cart" class="icon" />
      </div>
    </div>
  </header>
</template>

<style scoped>
.navbar {
  background-color: #fff;
  border-bottom: 1px solid #e5e5e5;
  padding: 10px 20px;
  font-family: 'Arial', sans-serif;
}

.navbar-container {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.logo {
  display: flex;
  align-items: center;
}

.logo-img {
  width: 40px; /* Adjust the size of the logo */
  height: auto;
  margin-right: 10px;
}

.brand-name {
  font-size: 1.2rem;
  font-weight: bold;
  color: #333;
}

.nav-links {
  display: flex;
  gap: 20px;
}

.nav-item {
  font-size: 1rem;
  color: #333;
  text-decoration: none;
}

.nav-item:hover {
  color: #777;
}

.nav-icons {
  display: flex;
  gap: 20px;
}

.icon {
  width: 24px; /* Adjust the size of the icons */
  height: auto;
  cursor: pointer;
}

</style>
