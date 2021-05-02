/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_putstr_fd.c                                     :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:43:33 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 15:44:01 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <unistd.h>
#include "libft.h"

void	ft_putstr_fd(char *str, int fd)
{
	int i;

	i = 0;
	if (!str)
		return ;
	while (str[i] != '\0')
		i++;
	write(fd, str, i);
}
