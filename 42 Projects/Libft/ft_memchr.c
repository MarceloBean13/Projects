/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_memchr.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:35:57 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 15:37:53 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <string.h>

void	*ft_memchr(const void *str, int c, size_t size)
{
	unsigned char	*temp;
	size_t			i;

	i = 0;
	temp = (unsigned char *)str;
	while (size--)
	{
		if (*temp++ == (unsigned char)c)
			return (temp - 1);
	}
	return (NULL);
}
